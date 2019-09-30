using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete
{
    public partial class gameforms : Form
    {
        public gameforms()
        {
            InitializeComponent();
        }
        loadspin object_obj = new loadspin();

        // below code is for load the gun
        private void loadedgunbt_Click(object sender, EventArgs e)
        {
            spinchambernt.Enabled = true;//spin  button will enabled after loading the gun  
           

            

           // show the image through resources 
            pictureBox1.Image = Russian_Roullete.Properties.Resources.load; 
            

            // below code is for load the sound
           

            //putting sound with load image from resources
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Russian_Roullete.Properties.Resources.load1);
            player.Play();

        }

        //below code is for loading bullets in gun and spinning it for random number 
        private void spinchambernt_Click(object sender, EventArgs e)
        {
            object_obj.awaypoint = 2;

            object_obj.spingunchamber = object_obj.slectnumber();// this function will change value from loadspin class
            Shootgunbt.Enabled = true;
          

            // image for spin chamber 
            pictureBox1.Image = Russian_Roullete.Properties.Resources.spin;
          

            // code for disable the spin button after spinning the bullets 

            spinchambernt.Enabled = false;

        }

        //below code is of fire button for firing 
        private void Shootgunbt_Click(object sender, EventArgs e)

        {
            // below code is of sound of fire while shooting 
           
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Russian_Roullete.Properties.Resources.shoot1);
            player.Play();
            if (object_obj.allbullet > 0 && object_obj.spingunchamber == 1) // this function will change value from loadspin class
            {
                // below coding is of result of fire button 

                MessageBox.Show("looser");
                loadedgunbt .Enabled = false; //this disabled the load button
                spinchambernt .Enabled = false;  // this disabled the spin button 
                Shootgunbt .Enabled = false; // this disabled the shoot button 
               AwayBt.Enabled = false; // this disabled the shootaway button 
                

                // below code is of image of  shoot 
                pictureBox1.Image = Russian_Roullete.Properties.Resources.shoot;
               



            }
            // below code is of random number during shoot button 

            else if (object_obj.allbullet > 0 && object_obj.spingunchamber != 1)
            {
             // below code  is for missing the bullet and showing the result 
                object_obj.allbullet = object_obj.allbullet - 1;
                if (object_obj.spingunchamber == 6)
                {
                    object_obj.spingunchamber = 1;
                }
                else
                {
                    object_obj.spingunchamber++;
                }

                MessageBox.Show("blank"); // if no bullets in gun will show message box of blank 

            }
        }

        // below code is of shootaway button 
        private void AwayBt_Click(object sender, EventArgs e)
        {
            
            if (object_obj.spingunchamber == 1 && object_obj.allbullet > 0 && object_obj.awaypoint == 2)
            {

                MessageBox.Show("you won 100");
                loadedgunbt.Enabled = false; // disabled load button 
                spinchambernt.Enabled = false; // disabled spin button 
                Shootgunbt.Enabled = false; // disabled shoot button 
                AwayBt.Enabled = false; // disabled shoot away button after result 

             
                pictureBox1.Image = Russian_Roullete.Properties.Resources.shoot;   //picture for shootaway 
                




            }

            // if player won in first attempt he score 100 in winning second attempt he will scored 50

            if (object_obj.spingunchamber == 1 && object_obj.allbullet > 0 && object_obj.awaypoint == 1)
            {

                MessageBox.Show("you won 50");
                loadedgunbt.Enabled = false; // after scoring disabled with load button 
               

                // picture for shoot 
                pictureBox1.Image = Russian_Roullete.Properties.Resources.shoot;
               

                spinchambernt.Enabled = false; // disabled with spin chamber 
                Shootgunbt.Enabled = false; // disable with shoot button 
                AwayBt.Enabled = false; // disabled with shoot away button 


            }
             // coding with else if 
            else if (object_obj.allbullet > 0 && object_obj.spingunchamber != 1)
            {
               // coading for shoot image from resources 
                pictureBox1.Image = Russian_Roullete.Properties.Resources.shoot;
              
                MessageBox.Show("miss shot"); // coding for missing shot after shoot 

                

                object_obj.allbullet = object_obj.allbullet - 1;
                object_obj.awaypoint = object_obj.awaypoint - 1;

                // this function will change value from loadspin class by using else if 

                if (object_obj.spingunchamber == 6)
                {
                    object_obj.spingunchamber = 1;
                }
                else
                {
                    object_obj.spingunchamber++;         
                }



            }

        }
         
        // below coding is for play again 
        private void btnplayagain_Click(object sender, EventArgs e)
        {
            (new play()).Show();
            this.Hide();     // coding with show and hide 
        }

        private void Gameforms_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
