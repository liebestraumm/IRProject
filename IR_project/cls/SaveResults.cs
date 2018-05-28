using System.IO;

namespace IR_project.cls
{
    class SaveResults
    {
        private Searching searching;

        public SaveResults(Searching searching)
        {
            this.searching = searching;
        }

        public void Save(string fileName )
        {
           TextWriter tsw = new StreamWriter(fileName, true);

            foreach (string[] s in searching.GetResultSavingInfo()) {
                tsw.WriteLine( s[0]+ "\t" + s[1] + "\t" + s[2] + "\t" + s[3] + "\t" + s[4] + "\t" + s[5]);
            }
           
           tsw.Close();
        }
    }
}
