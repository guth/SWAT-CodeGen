using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Code_Generator
{
    public partial class Form1 : Form
    {
        int[] b8 = new int[16];
        int gH = 0, iRank = 0, udg_RXP = 2500;
        // abcdefghijklmnopqrstuvwxyz0123456789_-!.([
        string characters = "abcdefghijklmnopqrstuvwxyz0123456789_-!.([";

        public Form1()
        {
            InitializeComponent();
            InitializeValueListBox();
            checksumLabel.Text = "Checksum: " + RedEncodeName(nameTextBox.Text);
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            b8 = new int[16];

            String sPlayer;
            String siClass, siArmor, siTrait, siRank, siSpec, siTalent;

            sPlayer = nameTextBox.Text;
            siClass = classComboBox.Text;
            siArmor = armorComboBox.Text;
            siTrait = traitComboBox.Text;
            siRank = rankComboBox.Text;
            siSpec = specComboBox.Text;
            siTalent = talentComboBox.Text;
            #region Misc
            /*
            b8[gH+2] = class
            b8[gH+3] = armor
            b8[gH+4] = trait
            b8[gH+5] = spec
            b8[gH+6] = Talent */
            #endregion

            #region Class
            // Determine Class/Weapon
            /*
             0        - Sniper
             1        - Medic
             2        - Tact
             3        - Psychologist
             4        - Heavy Ordnance
             5        - Demolition
             6        - Cyborg
             7        - Pyro
             8-9     - Watchman
             10-14 - Maverick */
            if (siClass == "Field Medic")
            {
                b8[gH + 2] = 1;//0;
            }
            else if (siClass == "Tactician")
            {
                b8[gH + 2] = 2;//1;
            }
            else if (siClass == "Covert Sniper")
            {
                b8[gH + 2] = 0;// 5;//3;
            }
            else if (siClass == "Pyrotechnician")
            {
                b8[gH + 2] = 7;//264;//4;
            }
            else if (siClass == "Demolitions")
            {
                b8[gH + 2] = 5;//3;//5;
            }
            else if (siClass == "Heavy Ordnance")
            {
                b8[gH + 2] = 4;//6;
            }
            else if (siClass == "Psychologist")
            {
                b8[gH + 2] = 3;//260;//7;
            }
            else if (siClass == "Cyborg")
            {
                b8[gH + 2] = 6;// 37;//9;
            }
                // New addition
                else if (siClass == "Technician")
                {
                    b8[gH + 2] = 15;
                }
                // New!
            else if (siClass == "Maverick - Assault Rifle")
            {
                b8[gH + 2] = 10;//8;
            }
            else if (siClass == "Maverick - Flamethrower")
            {
                b8[gH + 2] = 14;//8;
            }
            else if (siClass == "Maverick - Sniper Rifle")
            {
                b8[gH + 2] = 11;//8;
            }
            else if (siClass == "Maverick - Rocket Launcher")
            {
                b8[gH + 2] = 13;//8;
            }
            else if (siClass == "Maverick - Chaingun")
            {
                b8[gH + 2] = 12;//8;
            }
            else if (siClass == "Watchman - Laser Rifle")
            {   
                b8[gH + 2] = 8;
            }
            else if (siClass == "Watchman - Gatling Laser")
            {
                b8[gH + 2] = 9;
            }
#endregion
            #region Trait
            // Determine Trait
            if (siTrait == "Acrobat")
                b8[gH + 4] = 4;
            else if (siTrait == "Chem. Reliant")
                b8[gH + 4] = 8;
            else if (siTrait == "Dragoon")
                b8[gH + 4] = 3;
            else if (siTrait == "Energizer")
                b8[gH + 4] = 12;
            else if (siTrait == "Flower Child")
                b8[gH + 4] = 7;
            else if (siTrait == "Gadgeteer")
                b8[gH + 4] = 10;
            else if (siTrait == "Gifted")
                b8[gH + 4] = 1;
            else if (siTrait == "Healer")
                b8[gH + 4] = 6;
            else if (siTrait == "Pack Rat")
                b8[gH + 4] = 13;
            else if (siTrait == "Prowler")
                b8[gH + 4] = 11;
            else if (siTrait == "Rad. Resistant")
                b8[gH + 4] = 9;
            else if (siTrait == "Skilled")
                b8[gH + 4] = 0;
            else if (siTrait == "Survivalist")
                b8[gH + 4] = 2;
            else if (siTrait == "Swift Learner")
                b8[gH + 4] = 5;
            else if (siTrait == "Engineer")
                b8[gH + 4] = 14;
            else if (siTrait == "Focused")
                b8[gH + 4] = 15;
#endregion
            #region Rank
            // Determine rank
            if (siRank == "Rank 1")
                iRank = 1;
            else if (siRank == "Rank 2")
                iRank = 2;
            else if (siRank == "Rank 3")
                iRank = 3;
            else if (siRank == "Rank 4")
                iRank = 4;
            else if (siRank == "Rank 5")
                iRank = 5;
            else if (siRank == "Rank 6")
                iRank = 6;
            else if (siRank == "Rank 7")
                iRank = 7;
            else if (siRank == "Rank 8")
                iRank = 8;
            else if (siRank == "Rank 9")
                iRank = 9;
            else if (siRank == "Rank 10")
                iRank = 10;
            else if (siRank == "Rank 11")
                iRank = 11;
            else if (siRank == "Rank 12")
                iRank = 12;
            iRank = (iRank - 1) * udg_RXP;
#endregion
            #region Armor
            // Armors
            if (siArmor == "Light")
                b8[gH + 3] = 0;
            else if (siArmor == "Medium")
                b8[gH + 3] = 1;
            else if (siArmor == "Heavy")
                b8[gH + 3] = 2;
            else if (siArmor == "Advanced")
                b8[gH + 3] = 3;
            #endregion
            #region Specialization
            // Weaponry - Power Armor - Energy Cells - Cybernetics - Triage - Chemistry - Leadership - Robotics 
            if (siSpec == "Weaponry")
                b8[gH + 5] = 0;
            else if (siSpec == "Power Armor")
                b8[gH + 5] = 1;
            else if (siSpec == "Energy Cells")
                b8[gH + 5] = 2;
            else if (siSpec == "Cybernetics")
                b8[gH + 5] = 3;
            else if (siSpec == "Triage")
                b8[gH + 5] = 4;
            else if (siSpec == "Chemistry")
                b8[gH + 5] = 5;
            else if (siSpec == "Leadership")
                b8[gH + 5] = 6;
            else if (siSpec == "Robotics")
                b8[gH + 5] = 7;
            else if (siSpec == "Espionage")
                b8[gH + 5] = 8;
            #endregion
            #region Talent
            // Courage - Running - Sprinting -
            // Toughness - Tinkering - Hacking
            //if (siTalent == "Courage")
            //    b8[gH + 6] = 1;
            //else if (siTalent == "Running")
            //    b8[gH + 6] = 2;
            //else if (siTalent == "Sprinting")
            //    b8[gH + 6] = 3;
            //else if (siTalent == "Toughness")
            //    b8[gH + 6] = 4;
            //else if (siTalent == "Tinkering")
            //    b8[gH + 6] = 5;
            //else if (siTalent == "Hacking")
            //    b8[gH + 6] = 6;

            if (siTalent == "Courage")
                b8[gH + 6] = 0;
            else if (siTalent == "Wiring")
                b8[gH + 6] = 1;
            else if (siTalent == "Running")
                b8[gH + 6] = 2;
            else if (siTalent == "Spotting")
                b8[gH + 6] = 3;
            else if (siTalent == "Toughness")
                b8[gH + 6] = 4;
            else if (siTalent == "Tinkering")
                b8[gH + 6] = 5;
            else if (siTalent == "Hacking")
                b8[gH + 6] = 6;

            #endregion
            #region Medals
            if (medal1.Checked == true) // Commendation Bar
            {
                b8[gH + 7] = 1;
                b8[gH + 13] = 1;
            }
            if (medal21.Checked == true) // Exceptional Merit (Lvl 1)
            {
                b8[gH + 9] = 1;
                b8[gH + 15] = 1;
            }
            else if (medal22.Checked == true) // Exceptional Merit (Lvl 2)
            {
                b8[gH + 9] = 2;
                b8[gH + 15] = 2;
            }
            else if (medal23.Checked == true) // Exceptional Merit (Lvl 3)
            {
                b8[gH + 9] = 3;
                b8[gH + 15] = 3;
            }
            if (medal3.Checked == true) // Life Saving Award
            {
                b8[gH + 8] = 1;
                b8[gH + 14] = 1;
            }
            if (medal4.Checked == true) // Key to the City
                b8[gH + 10] = 1;
            if (medal5.Checked == true) // Medal of Honor
                b8[gH + 11] = 1;
            if (medal6.Checked == true) // Police Combat Cross
                b8[gH + 12] = 1;
            #endregion

            int[] ay = new int[1];
            ay[0] = 0;
            int[] aU = new int[1];
            aU[0] = iRank;//0?
            //String code = k7(iP, ay[iP], aU[iP]);
            String code = k7(0, ay[0], aU[0]);
            codeDisplay.Text = code.Substring(0, 4) + "-"
                + code.Substring(4, 4) + "-" + code.Substring(8, 4)
                + "-" + code.Substring(12, 4);
        }
        
        private string k7(int iP,int kK,int Fu) // Same
        {
            int aV = 2500;
            int gH=iP*15;
            b8[gH+7] = 4-kK;
            b8[gH+8] = f3(Fu,aV);
            if (b8[gH+8]>9)
                b8[gH+9] = 0;
            else
                b8[gH+9] = f3(Fu%aV,aV/500);
            return k4(GetPlayerName(), gH);
        }
        
        private string GetPlayerName()
        {
             string playername = nameTextBox.Text;
             return playername;
        }
        
        private int f3(int i, int j) /*RedDiv*/
        {
            return System.Convert.ToInt32((i - (i % j)) / j);
        }

        private string k4(string k1,int gH) // Same
        {
            int i;
            string k5 = ks(b8[gH+2],b8[gH+3],b8[gH+4],b8[gH+5],b8[gH+6],b8[gH+7],b8[gH+8],b8[gH+9],b8[gH+10],b8[gH+11],b8[gH+12],b8[gH+13],b8[gH+14],b8[gH+15]);
            string k6 = kr(k1,gH);
            //k5 = SubString(k5,0,3)+SubString(k6,4,5)+SubString(k5,3,6)+SubString(k6,3,4)+SubString(k5,6,9)+SubString(k6,1,3)+SubString(k5,9,11)+SubString(k6,0,1);
            k5 = k5.Substring(0, 3) + k6.Substring(4, 1) + k5.Substring(3, 3) + k6.Substring(3, 1) + k5.Substring(6, 3) + k6.Substring(1, 2) + k5.Substring(9, 2) + k6.Substring(0, 1);
            i = S2I(k5.Substring(0,1));
            //return SubString(k5, 0, 1) + SubString(k5, 16 - i, 16) + SubString(k5, 1, 16 - i);
            return k5.Substring(0, 1) + k5.Substring(16 - i, i) + k5.Substring(1, 15 - i);
        }
        
        /* Old, uneditted. Change back to ks() to use */ private string ks2(int gh,int IM,int kS,int kt,int kT,int kK,int FM,int Fu,int ku,int kU,int kv,int kV,int kw,int kW)
        {
            int kx;
            int kX = RandomNumber(0,4)*2; //gh = class
            if(kT>0)                     //IM = Armor
            {                           //ks = Trait
                if(gh==0)               //kt = Spec
                {                       //kT = Talent
                    if (kT==1)
                        kT=1;
                    else if(kT==3)
                        kT=2;
                    else if(kT==5)
                        kT=3;
                    else
                        kT=0;
                }  
                else if(gh==1)
                {
                    if(kT==1)
                        kT=1;
                    else if(kT==3)
                        kT=2;
                    else if(kT==6)
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh==2)
                {
                    if(kT==1)
                        kT=1;
                    else if(kT==2)
                        kT=2;
                    else if(kT==3)
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh==3)
                {
                    if(kT==1) 
                        kT=1;
                    else if(kT==3) 
                        kT=2;
                    else if(kT==4) 
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh>9 && gh<15)
                {
                    if (kT==2)
                        kT=1;
                    else if(kT==4)
                        kT=2;
                    else if(kT==5)
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh==4)
                {
                    if(kT==3)
                        kT=1;
                    else if(kT==4)
                        kT=2;
                    else if(kT==5)
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh==5)
                {
                    if(kT==2)
                        kT=1;
                    else if(kT==4)
                        kT=2;
                    else if(kT==6)
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh==6)
                {
                    if (kT==1)
                        kT=1;
                    else if(kT==2)
                        kT=2;
                    else if(kT==6)
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh==7)
                {
                    if (kT==2)
                        kT=1;
                    else if (kT==5)
                        kT=2;
                    else if (kT==6)
                        kT=3;
                    else
                        kT=0;
                }
                else if(gh>7 && gh<10)
                {
                    if (kT==4)
                        kT=1;
                    else if (kT==5)
                        kT=2;
                    else if (kT==6)
                        kT=3;
                    else
                        kT=0;
                }
                else
                {
                    kT=0;
                }
            }
            if(gh==6)
            {
                IM=2;
            }
            else if(gh==8)
            {
                gh=6;
                IM=0;
            }
            else if(gh==9)
            {
                gh=6;
                IM=1;
            }
            else if(gh>9)
            {
                gh=gh-10;
                kX=kX+1;
            }
            if (IM>2)
            {
                IM=2;
            }
            if (FM>10)
            {
                if((ku+kU)>1)
                {
                    FM=14;
                }
                else if(ku>0)
                {
                    FM=13;
                }
                else if (kU>0)
                {
                    FM=12;
                }
            }
            if (FM>8)
            {
                if (kK<4)
                {
                    if (kv<1)
                        kK=1;
                    else
                        kK=2;
                }
                else
                {
                    if (kv<1)
                        kK=3;
                }
            }
            else if(FM>5 && kK<2)
                kK=2;
            else if(FM>2 && kK<1)
                kK=1;
            if (FM<9)
            {
                if (kK<3)
                {
                    kV=0;
                    kw=0;
                }
                else if(kK<1)
                    kW=0;
            }
            kx=f3(Fu,10)+50*FM+50*15*kK+50*15*5*kV+50*15*5*2*kw+50*15*5*2*2*kW;
            kx=kx+50*15*5*2*2*4*(gh+8*IM+8*3*kS+8*3*18*kt+8*3*18*9*kT);
            return kX + "" + ki(kx, 9) + Fu % 10 + "";
            //return I2S(kX) + ki(kx, 9) + I2S(Fu % 10);
        }
        private string ks(int gh, int IM, int kS, int kt, int kT, int kK, int FM, int Fu, int ku, int kU, int kv, int kV, int kw, int kW)
        {
            int kx;
            int kX = RandomNumber(0, 4) * 2; //gh = class**
            if (kT > 0)                     //IM = Armor
            {                           //ks = Trait
                if (gh == 0)               //kt = Spec
                {                       //kT = Talent**
                    if (kT == 1)
                        kT = 1;
                    else if (kT == 2)//3
                        kT = 2;
                    else if (kT == 5)
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh == 1)
                {
                    if (kT == 1)
                        kT = 1;
                    else if (kT == 4)//3
                        kT = 2;
                    else if (kT == 6)
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh == 2)
                {
                    if (kT == 1)
                        kT = 1;
                    else if (kT == 2)
                        kT = 2;
                    else if (kT == 6)//3
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh == 3)
                {
                    if (kT == 1)
                        kT = 1;
                    else if (kT == 3)
                        kT = 2;
                    else if (kT == 6)//4
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh > 9 && gh < 15)
                {
                    if (kT == 2)
                        kT = 1;
                    else if (kT == 4)
                        kT = 2;
                    else if (kT == 5)
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh == 4)
                {
                    if (kT == 6)//3
                        kT = 1;
                    else if (kT == 4)
                        kT = 2;
                    else if (kT == 5)
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh == 5)
                {
                    if (kT == 2)
                        kT = 1;
                    else if (kT == 4)
                        kT = 2;
                    else if (kT == 3)//6
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh == 6)
                {
                    if (kT == 3)//1
                        kT = 1;
                    else if (kT == 2)
                        kT = 2;
                    else if (kT == 6)
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh == 7)
                {
                    if (kT == 3)//2
                        kT = 1;
                    else if (kT == 5)
                        kT = 2;
                    else if (kT == 1)//6
                        kT = 3;
                    else
                        kT = 0;
                }
                else if (gh > 7 && gh < 10)
                {
                    if (kT == 4)
                        kT = 1;
                    else if (kT == 5)
                        kT = 2;
                    else if (kT == 3)//6
                        kT = 3;
                    else
                        kT = 0;
                }
                else
                {
                    kT = 0;
                }
            }
            if (gh == 6)
            {
                IM = 2;
            }
            else if (gh == 8)
            {
                gh = 6;
                IM = 0;
            }
            else if (gh == 9)
            {
                gh = 6;
                IM = 1;
            }
            else if (gh > 9)
            {
                gh = gh - 10;
                kX = kX + 1;
            }
            if (IM > 2)
            {
                IM = 2;
            }
            if (FM > 10)
            {
                if ((ku + kU) > 1)
                {
                    FM = 14;
                }
                else if (ku > 0)
                {
                    FM = 13;
                }
                else if (kU > 0)
                {
                    FM = 12;
                }
            }
            if (FM > 8)
            {
                if (kK < 4)
                {
                    if (kv < 1)
                        kK = 1;
                    else
                        kK = 2;
                }
                else
                {
                    if (kv < 1)
                        kK = 3;
                }
            }
            else if (FM > 5 && kK < 2)
                kK = 2;
            else if (FM > 2 && kK < 1)
                kK = 1;
            if (FM < 9)
            {
                if (kK < 3)
                {
                    kV = 0;
                    kw = 0;
                }
                else if (kK < 1)
                    kW = 0;
            }
            kx = f3(Fu, 10) + 50 * FM + 50 * 15 * kK + 50 * 15 * 5 * kV + 50 * 15 * 5 * 2 * kw + 50 * 15 * 5 * 2 * 2 * kW;
            kx = kx + 50 * 15 * 5 * 2 * 2 * 4 * (gh + 8 * IM + 8 * 3 * kS + 8 * 3 * 18 * kt + 8 * 3 * 18 * 9 * kT);
            return kX + "" + ki(kx, 9) + Fu % 10 + "";
            //return I2S(kX) + ki(kx, 9) + I2S(Fu % 10);
        } //Changed, same now

        //bK(BK,Lo[kd+2],Lo[kd+3],Lo[kd+4],Lo[kd+5],Oj,Lo[kd+7],Lo[kd+8],Lo[kd+9],Lo[kd+10],Lo[kd+11],Lo[kd+12],Lo[kd+13],Lo[kd+14],Lo[kd+15])
        private string kr(string kR,int gH)
        {
            int i=RedEncodeName(kR)*(b8[gH+6]+1)+(b8[gH+2]+4)*(b8[gH+2]+6)+(b8[gH+8]+1)*(b8[gH+9]+1)+(b8[gH+5]+1)*7654-(b8[gH+4]+1)*419-(b8[gH+3]+1)*50;
            i=i+(b8[gH+10]+1)*4+(b8[gH+11]+1)*9+(b8[gH+12]+1)*19+(b8[gH+13]+1)*39+(b8[gH+14]+1)*79+(b8[gH+15]+1)*159;
            i=i+100*(b8[gH+7]+1)*(i % 1000);
            while( i >= 100000)
            {
                //exitwhen i<100000
                i=(i % 100000)+f3(i,100000);
            }
            return ki(i, 5);
        } // Same
        
        // redscull's EncodeName
        private int RedEncodeName2(string s) /*RedEncodeName + kQ */ {
            int i = 1;
            int l = s.Length;
            int I2 = 0;
            while (i <= l)
            {
                I2 = I2 + RedEncodeChar(s.Substring(i-1,1)) * ((i % 3) + 1);
                i = i + 1;
            }
            return I2;
        }

        // redscull's EncodeChar, part of his EncodeName
        private int RedEncodeChar /* kq */ (string c) /*RedEncodeChar*/ {
            if (c == "a" || c == "A")
                return 12;
            else if (c == "b" || c == "B")
                return 25;
            else if (c == "c" || c == "C")
                return 23;
            else if (c == "d" || c == "D")
                return 22;
            else if (c == "e" || c == "E")
                return 13;
            else if (c == "f" || c == "F")
                return 36;
            else if (c == "g" || c == "G")
                return 35;
            else if (c == "h" || c == "H")
                return 24;
            else if (c == "i" || c == "I")
                return 14;
            else if (c == "j" || c == "J")
                return 30;
            else if (c == "k" || c == "K")
                return 33;
            else if (c == "l" || c == "L")
                return 32;
            else if (c == "m" || c == "M")
                return 31;
            else if (c == "n" || c == "N")
                return 21;
            else if (c == "o" || c == "O")
                return 15;
            else if (c == "p" || c == "P")
                return 19;
            else if (c == "q" || c == "Q")
                return 37;
            else if (c == "r" || c == "R")
                return 26;
            else if (c == "s" || c == "S")
                return 18;
            else if (c == "t" || c == "T")
                return 20;
            else if (c == "u" || c == "U")
                return 17;
            else if (c == "v" || c == "V")
                return 28;
            else if (c == "w" || c == "W")
                return 34;
            else if (c == "x" || c == "X")
                return 27;
            else if (c == "y" || c == "Y")
                return 16;
            else if (c == "z" || c == "Z")
                return 29;
            else if (c == "0")
                return 9;
            else if (c == "1")
                return 11;
            else if (c == "2")
                return 8;
            else if (c == "3")
                return 10;
            else if (c == "4")
                return 6;
            else if (c == "5")
                return 2;
            else if (c == "6")
                return 3;
            else if (c == "7")
                return 7;
            else if (c == "8")
                return 5;
            else if (c == "9")
                return 4;
            else if (c == "_")
                return 1;
            else if (c == "-")
                return 38;
            else if (c == "!")
                return 39;
            else if (c == ".")
                return 40;
            else if (c == "(" || c == ")")
                return 41;
            else if (c == "[" || c == "]")
                return 42;
            else
                return 43;
        }

        // Bike's EncodeName (optimized)
        private int RedEncodeName(string myName)
		{
            if (myName.Equals(""))
            {
                return 0;
            }

            #region junk commented stuff
            //myName = myName.ToLower();
            //int CharPos = 0;
            //int NameLen = myName.Length;
            //int iChecksum = 0;

            //while(true)
            //{
            //    iChecksum += EncodeChar(myName.Substring(CharPos,1).ToCharArray()[0])*(((CharPos+1)%3)+1);
            //    CharPos++;
            //    if(CharPos >= NameLen)
            //        break;
            //}
            #endregion

            char[] chars = myName.ToLower().ToCharArray();
            int iChecksum = 0;
            for (int k = 0; k < myName.Length; k++)
            {
                iChecksum += EncodeChar(chars[k]) * (((k + 1) % 3) + 1);
            }
		    return iChecksum;
		}
		
        // Bike's Encode Char, part of his EncodeName
	    private int EncodeChar(int iChar)
		{
		    // a-z  97.122 // A-Z  65.90 // 0-9  48.49.50.51.52.53.54.55.56.57
		    switch(iChar)
			{
			    case 97: return 12; // a
			    case 98: return 25; // b
			    case 99: return 23; // c
			    case 100: return 22; // d
			    case 101: return 13; // e
			    case 102: return 36; // f
			    case 103: return 35; // g
			    case 104: return 24; // h
			    case 105: return 14; // i
			    case 106: return 30; // j
			    case 107: return 33; // k
			    case 108: return 32; // l
			    case 109: return 31; // m
			    case 110: return 21; // n
			    case 111: return 15; // o
			    case 112: return 19; // p
			    case 113: return 37; // q
			    case 114: return 26; // r
			    case 115: return 18; // s
			    case 116: return 20; // t
			    case 117: return 17; // u
			    case 118: return 28; // v
			    case 119: return 34; // w
			    case 120: return 27; // x
			    case 121: return 16; // y
			    case 122: return 29; // z
			    case 48: return 9; // 0
			    case 49: return 11; // 1
			    case 50: return 8; // 2
			    case 51: return 10; // 3
			    case 52: return 6; // 4
			    case 53: return 2; // 5
			    case 54: return 3; // 6
			    case 55: return 7; // 7
			    case 56: return 5; // 8
			    case 57: return 4; // 9
			    case 95: return 1; // _
			    case 45: return 38; // -
			    case 33: return 39; // !
			    case 46: return 40; // .
			    case 40: return 41; // (
			    case 41: return 41; // )
			    case 91: return 42; // [
			    case 93: return 42; // ]
			    default: return 43;
			}
		}

        private string RedDecodeChar(int x)
        {
            int k = 0;
            while (k < characters.Length)
            {
                int value = RedEncodeName(characters.Substring(k, 1));
                value /= 2; // Since first letter = times by 2.
                if (value == x)
                {
                    return characters.Substring(k, 1);
                }
                k++;
            }
            return "*";
        }

        private void InitializeValueListBox()
        {
            valueListBox.Items.Add("231");
            for (int k = 1; k <= 9; k++)
            {
                valueListBox.Items.Add(k + "     -     " + RedDecodeChar(k));
            }

            for (int k = 10; k < 43; k++)
            {
                valueListBox.Items.Add(k + "   -     " + RedDecodeChar(k));
            }
        }

        private string ki(int i, int gZ) /* I2SP */ {
            string s=i + "";
            //string s=I2S(i);
            while(s.Length<gZ)
            {
                s="0"+s;
            }
            return s;
        }
        
        private int RandomNumber(int min, int max) {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private int S2I(string s)
        {
            int i = 0;
            for (int k = 0; k <= 9999; k++)
            {
                if (k < 10)
                    if (s == "000" + k)
                        i = k;
                if (k < 100)
                    if (s == "00" + k)
                        i = k;
                if (k < 1000)
                    if (s == "0" + k)
                        i = k;
                if (s == k + "")
                    i = k;
            }
            return i;
        }

        // Copy code to clipboard
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(codeDisplay.Text);
        }

        // Clear input name text box
        private void codegenNameClearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            nameTextBox.Select();
        }

        // Update checksum
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            checksumLabel.Text = "Checksum: " + RedEncodeName(nameTextBox.Text);
        }

        // Update Talent box when the class is changed.
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string first = classComboBox.Text.Substring(0, 2); // First 2 letters of class

            talentComboBox.Items.Clear();
            talentComboBox.Items.Add("None");

            List<String> temp = new List<String>(3); // Holds the 3 talents of the class

            #region Adding talents to temp per class
            if (first == "Fi") // Field Medic
            {
                temp.Add("Courage");
                temp.Add("Wiring");
                temp.Add("Toughness");
                temp.Add("Hacking");
            }
            else if (first == "Ta") // Tactician
            {
                temp.Add("Courage");
                temp.Add("Wiring");
                temp.Add("Running");
                temp.Add("Hacking");
            }
            else if (first == "Co") // Covert Sniper
            {
                temp.Add("Courage");
                temp.Add("Wiring");
                temp.Add("Running");
                temp.Add("Tinkering");
            }
            else if (first == "Py") // Pyrotechnician
            {
                temp.Add("Courage");
                temp.Add("Wiring");
                temp.Add("Spotting");
                temp.Add("Tinkering");
            }
            else if (first == "De") // Demolitions
            {
                temp.Add("Courage");
                temp.Add("Running");
                temp.Add("Spotting");
                temp.Add("Toughness");
            }
            else if (first == "He") // Heavy Ordnance
            {
                temp.Add("Courage");
                temp.Add("Toughness");
                temp.Add("Tinkering");
                temp.Add("Hacking");
            }
            else if (first == "Ps") // Psychologist
            {
                temp.Add("Courage");
                temp.Add("Wiring");
                temp.Add("Spotting");
                temp.Add("Hacking");
            }
            else if (first == "Cy") // Cyborg
            {
                temp.Add("Courage");
                temp.Add("Running");
                temp.Add("Spotting");
                temp.Add("Hacking");
            }
            else if (first == "Ma") // Maverick
            {
                temp.Add("Courage");
                temp.Add("Running");
                temp.Add("Toughness");
                temp.Add("Tinkering");
            }
            else if (first == "Wa") // Watchman
            {
                temp.Add("Courage");
                temp.Add("Spotting");
                temp.Add("Toughness");
                temp.Add("Tinkering");
            }
            else if (first == "Te") // Technician
            {
                temp.Add("Courage");
            }
            #endregion

            // Add the new talent list to the combo box.
            foreach(String s in temp)
            {
                talentComboBox.Items.Add(s);
            }

            if (temp.Contains(talentComboBox.Text)) // If currently selected talent is in the new list,
            {
                // Nothing needs to change.
            }
            else
            {
                // Old talent is not in list. Reset the text.
                talentComboBox.Text = "-- Select Talent --";
            }
        }

        // Opens RCPD.exe
        private void rcpdButton_Click(object sender, EventArgs e)
        {
            Process.Start(System.Windows.Forms.Application.StartupPath
                            + "/Programs/RCPD.exe");
        }

        // Opens Warcraft name spoofer -- ***DISABLED UNTIL FURTHER REVIEW***
        private void spoofButton_Click(object sender, EventArgs e)
        {
            //Process.Start(System.Windows.Forms.Application.StartupPath
            //                + "/Programs/W3XNameSpoofer11800.exe");
        }

        private void medal21_Click(object sender, EventArgs e)
        {
            ChangeMerit(1);
        }

        private void medal22_Click(object sender, EventArgs e)
        {
            ChangeMerit(2);
        }

        private void medal23_Click(object sender, EventArgs e)
        {
            ChangeMerit(3);
        }

        private void ChangeMerit(int n)
        {
            if(n == 1)
            {
                medal21.Checked = !medal21.Checked;
                medal22.Checked = false;
                medal23.Checked = false;
            }
            if(n == 2)
            {
                medal21.Checked = false;
                medal22.Checked = !medal22.Checked;
                medal23.Checked = false;
            }
            if(n == 3)
            {
                medal21.Checked = false;
                medal22.Checked = false;
                medal23.Checked = !medal23.Checked;
            }

        }
    }
}
