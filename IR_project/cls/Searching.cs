using System;
using Lucene.Net.Search;
using Lucene.Net.QueryParsers;
using System.Text.RegularExpressions;

namespace IR_project
{
    class Searching
    {
        private Lucene.Net.Store.Directory luceneIndexDirectory;
        private Lucene.Net.Search.IndexSearcher searcher;
        private Lucene.Net.QueryParsers.MultiFieldQueryParser parser;
        private Init init;
        public string Log;
        private System.Collections.ArrayList ResultSet,ResultSavingInfo;
        private string QueryID, QueryStr;


        public Searching(Init init, Lucene.Net.Store.Directory luceneIndexDirectory, string QueryStr, string QueryID)
        {
            this.init = init;
            this.luceneIndexDirectory = luceneIndexDirectory;
            this.QueryStr = QueryStr;
            this.QueryID = QueryID.PadLeft(3, '0');

            CreateSearcher();
            CreateParser();

            SetResults(SearchIndex(QueryStr));

            CleanUpSearch();
        }

        private void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
        }

        private void CreateParser()
        {
            parser = new MultiFieldQueryParser(init.getVersion(), new string[] { ".W",".T",".A",".B" }, init.getAnalyser());

        }

        private void CleanUpSearch()
        {
            searcher.Dispose();
        }


        private TopDocs SearchIndex(string querytext)
        {

            Log += "\r\nSearching for ' " + querytext+" ' ~ ' ";

            querytext = querytext.ToLower();
            querytext = Regex.Replace(querytext, @"[^0-9a-z.]+", " ");
            //querytext = querytext.Replace(",",String.Empty);
            Log += querytext + " ' ";

            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 1400);

            Log += "\r\nNumber of results is " + results.TotalHits;
            return results;

        }

        private void SetResults(TopDocs results)
        {
            ResultSet = new System.Collections.ArrayList();
            ResultSavingInfo = new System.Collections.ArrayList();
            int rank = 0;
            string CPath = init.getCollectionPath();


                foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                // retrieve the document from the 'ScoreDoc' object

                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);

                int firstNewLineIndx = doc.Get(".W").ToString().IndexOf("\n");
                string DocId = doc.Get(".I").ToString().Replace("\n", String.Empty);

                ResultSet.Add("[" + DocId + "]. " +
                    doc.Get(".T").ToString().Replace("\n", String.Empty) + " ( R" + rank + " )\r\n" +
                    "       " + doc.Get(".A").ToString().Replace("\n", String.Empty) + "\r\n" +
                    "       " + doc.Get(".B").ToString().Replace("\n", String.Empty) + "\r\n" +
                    "       " + doc.Get(".W").ToString().Substring(0, firstNewLineIndx) + " ...\r\n" +
                    "       " + "file://" + CPath + "/" + DocId + ".txt");

                ResultSavingInfo.Add(new string[] { QueryID, "Q0", DocId, rank.ToString(), scoreDoc.Score.ToString(), "9583131_9837809_9539361_ACH" });
            }
        }

        public System.Collections.ArrayList GetResultSet()
        {
            return ResultSet;
        }

        public System.Collections.ArrayList GetResultSavingInfo()
        {
            return ResultSavingInfo;
        }
    }
}