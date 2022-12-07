namespace cookie_clicker
{
    public partial class form1 : form
    {
        int cookiescore = 500000;
        double upgrademulti = 1;
        
        
        public form1()
        {
            initializecomponent();
        }

        private void label1_click(object sender, eventargs e) // score
        {
            label1.text = "score:" + cookiescore.tostring();
        }

        private void button1_click(object sender, eventargs e) //cookie
        {
            cookiescore = convert.toint32(cookiescore + upgrademulti);
            label1.text = "score:" + cookiescore.tostring();
            button3.text = "cost: "+upgradecursor.tostring();

        }
        double upgradepreis = 50;
        int i = 0;
        private void button2_click(object sender, eventargs e) //upgrade 1
        {
            if (cookiescore >= upgradepreis && i<20)
            {
                    i++;
                    upgrademulti *= 1.05;
                    cookiescore -= convert.toint32(upgradepreis);
                    label1.text = "score:" + cookiescore.tostring();
                    upgradepreis *= 1.2;
                    button2.text = "cost: " + convert.toint32(upgradepreis + 1);
            } else
            {
                button2.text = "not available";
            }
        }

        double upgradecursor = 500;

        private void button3_click(object sender, eventargs e) //cursor upgrade
        {
            
            if(cookiescore>=upgradecursor)
            {
                cookiescore-=convert.toint32(upgradecursor);
                upgrademulti *= 2;
                upgradecursor *= 5;
                button3.text = "cost: " + convert.toint32(upgradecursor.tostring());
                label1.text = "score:" + cookiescore.tostring();
            }
        }

        private void label3_click(object sender, eventargs e)
        {

        }
        double autoclicker = 100;
        bool upgrade = false;
        private void button4_click(object sender, eventargs e)
        {
            if(cookiescore >= autoclicker)
            {
                cookiescore-=convert.toint32(autoclicker);
                upgrade = true;
                while (upgrade == true)
                {

                    button4.sleep(1000);
                    cookiescore += 1;
                    label1.text = "score:" + cookiescore.tostring();

                }
            }
        }




        
    }
}