namespace _20230327ss_cs
{
    internal class Csoki
    {
        public string CsokiNeve;
        public string CsokiKod;
        public int CsokiAr;
        public int CsokiDb;

        public Csoki(string Sor)
        {
            var dbok = Sor.Split(";");
            this.CsokiNeve = dbok[0];
            this.CsokiKod = dbok[1];
            this.CsokiAr = int.Parse(dbok[2]);
            this.CsokiDb = int.Parse(dbok[3]);
        }
    }
}