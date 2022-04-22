namespace Checkpoints
{
    public class Planet
    {
        /// <summary>
        /// 0 = Rocky, 1 = Gas giant
        /// </summary>
        public int PlanetType
        {
            get;set;
        }

        public string Name { get; set; }

        /// <summary>
        /// Distance from the sun in AU
        /// </summary>
        public decimal StellarDistance { get; set;}
    }
}
