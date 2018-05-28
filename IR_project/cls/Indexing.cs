using System;
using System.Collections.Generic;
using Lucene.Net.Documents;
using Lucene.Net.Index; 


namespace IR_project
{
    class Indexing
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        public static Lucene.Net.Util.Version Version;
        private string CollectionPath, IndexPath;
        public string Output;

        public void setAnalyser(Lucene.Net.Analysis.Analyzer analyzer)
        {
            this.analyzer = analyzer;
        }

        public Lucene.Net.Store.Directory getluceneIndexDirectory()
        {
            return luceneIndexDirectory;
        }

        public Indexing(Init init)
        {
            IndexPath = init.getIndexPath();
            CollectionPath =init.getCollectionPath();
            Version = init.getVersion();

            luceneIndexDirectory = null;
            writer = null; 

            OpenIndex(IndexPath);
            analyzer = init.getAnalyser();
            CreateWriter();
            
            foreach (string s in GetDocList())
            {
                IndexText(s);
            }

            CleanUp();
        }

        public List<string> GetDocList() {
            FileReader fr = new FileReader();
            List<string> l = new List<string>();
            foreach (System.IO.FileInfo fi in fr.GetDirFiles(CollectionPath))
            {
                l.Add(fr.ReadFile(fi.FullName));
            }
            return l;
        }

        public void OpenIndex(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
        }

        public void CreateWriter()
        {
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
        }


        public void IndexText(string text)
        {

            Output += "Indexing " + text + "/r/n";

            Dictionary<string, string> fields= new Dictionary<string, string>();

            // getting I
            int pFrom = text.IndexOf(".I") + 3;
            int pTo = text.LastIndexOf(".T");
            fields.Add(".I", text.Substring(pFrom, pTo - pFrom));

            // getting T
            pFrom = text.IndexOf(".T")+2;
            pTo = text.LastIndexOf(".A");
            fields.Add(".T", text.Substring(pFrom, Math.Abs(pTo - pFrom)));

            // getting A
            pFrom = text.IndexOf(".A") + 2;
            pTo = text.LastIndexOf(".B");
            fields.Add(".A", text.Substring(pFrom, Math.Abs(pTo - pFrom)));

            // getting B
            pFrom = text.IndexOf(".B") + 2;
            pTo = text.LastIndexOf(".W");
            fields.Add(".B", text.Substring(pFrom, Math.Abs(pTo - pFrom)));

            // getting W
            pFrom = text.IndexOf(".W") + 3;
            pTo = text.Length;
            
            fields.Add(".W", text.Substring(pFrom, Math.Abs(pTo - pFrom)).Replace(fields[".T"],""));



            Lucene.Net.Documents.Field field_I = new Field(".I", fields[".I"], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Field field_T = new Field(".T", fields[".T"], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Field field_A = new Field(".A", fields[".A"], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Field field_B = new Field(".B", fields[".B"], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Field field_W = new Field(".W", fields[".W"], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Document doc = new Document();

            doc.Add(field_I);
            doc.Add(field_T);
            doc.Add(field_A);
            doc.Add(field_B);
            doc.Add(field_W);

            writer.AddDocument(doc);
        }

        /// <summary>
        /// Flushes buffers and closes the index
        /// </summary>
        public void CleanUp()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }


        /// <summary>
        /// The main program
        /// </summary>
        /// <param name="args">command line arguments</param>
     /*   static void Main(string[] args)
        {


        }*/
    }
}