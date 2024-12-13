using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpEgitimKampi301.EntityFrameworkProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEntityFrameworkTravelDbEntities db = new EgitimKampiEntityFrameworkTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text =db.Location.Sum(x=>x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = Math.Ceiling(db.Location.Average(x => x.Capacity) ?? 0).ToString();


            lblAvgLocationPrice.Text = ((decimal)db.Location.Average(x => x.Price)).ToString("N2") + " ₺";
            
            int LastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == LastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(YieldAwaitable => YieldAwaitable.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select
                (y => y.GuideName + " " + y.GuiderSurname).FirstOrDefault().ToString();

            var maxCapacity =db.Location.Max(x=>x.Capacity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
       
            var guideIdByNameFurkanDemir=db.Guide.Where(x=>x.GuideName=="Furkan" && x.GuiderSurname=="Demir").Select
                (y=>y.GuideId).FirstOrDefault();
            lblFurkanDemirLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByNameFurkanDemir).Count().ToString();
        
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
