using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADoors
{
    public partial class MainForm : Form
    {
        readonly Dictionary<string, Door> doors = new Dictionary<string, Door>();
        readonly Door currentDoor = new Door();
       
        public MainForm()
        {
            InitializeComponent();

            List<string> list = SQLClass.Select(
                "SELECT Name, Price, Id FROM models ORDER BY id");
            List<Image> images = SQLClass.SelectImages("SELECT Picture FROM models ORDER BY id");
            

            ModelChoice.Items.Clear();
            for (int i = 0; i < list.Count; i += 3)
            {
                ModelChoice.Items.Add(list[i]);
                List<string> colors = SQLClass.Select(
                    "SELECT Name FROM colors JOIN model_colors ON colors.Id = model_colors.color_id WHERE model_id = " + list[i+2]);
                
                Door door = new Door
                {
                    BasePrice = Convert.ToInt32(list[i + 1]),
                    Model = list[i],
                    Picture = images[i / 3],
                    ColorsList = colors
                };

                doors.Add(door.Model, door);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLClass.CloseConnection();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Door door = doors[ModelChoice.Text];
                door.HasDoorhandle = DoorHandleChoice.Checked;
                door.HasPlatband = PlatbandChoice.Checked;
                door.Color = ColorChoice.Text;
                door.Width = Convert.ToInt32(WidthChoice.Value);
                door.Type = TypeChoice.Text;

                Pricelabel.Text = door.ComputeCost(Convert.ToInt32(DoorCountChoice.Value)).ToString() + " рублей";
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Некорректные значения!",
                    "Ошибка ввода данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ModelChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ModelChoice.Text != "")
                    DoorPB.Image = doors[ModelChoice.Text].Picture;
            }
            catch (Exception) { }
            
            if (ModelChoice.Text != "" && ColorChoice.Text != "")
                ComputeButton_Click(sender, e);
        }
    }
}
