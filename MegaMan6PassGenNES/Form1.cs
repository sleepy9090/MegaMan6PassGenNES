/**
 *  @file           Form1.cs / FormMegaMan6PassGenNES
 *  @brief          Password Generator for the NES game MegaMan IV
 *  @copyright      Shawn M. Crawford 2019
 *  @date           04/12/2019
 *
 *  @remark Author  Shawn M. Crawford (sleepy9090)
 *
 *  @note           N/A
 *
 */
using System;
using System.Windows.Forms;

namespace MegaMan6PassGenNES
{
    public partial class FormMegaMan6PassGenNES : Form
    {
        public FormMegaMan6PassGenNES()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            DisablePasswordCheckboxes();
        }

        private void DisablePasswordCheckboxes()
        {
            checkBoxA1.Enabled = false;
            checkBoxA2.Enabled = false;
            checkBoxA3.Enabled = false;
            checkBoxA4.Enabled = false;
            checkBoxA5.Enabled = false;
            checkBoxA6.Enabled = false;

            checkBoxB1.Enabled = false;
            checkBoxB2.Enabled = false;
            checkBoxB3.Enabled = false;
            checkBoxB4.Enabled = false;
            checkBoxB5.Enabled = false;
            checkBoxB6.Enabled = false;

            checkBoxC1.Enabled = false;
            checkBoxC2.Enabled = false;
            checkBoxC3.Enabled = false;
            checkBoxC4.Enabled = false;
            checkBoxC5.Enabled = false;
            checkBoxC6.Enabled = false;

            checkBoxD1.Enabled = false;
            checkBoxD2.Enabled = false;
            checkBoxD3.Enabled = false;
            checkBoxD4.Enabled = false;
            checkBoxD5.Enabled = false;
            checkBoxD6.Enabled = false;

            checkBoxE1.Enabled = false;
            checkBoxE2.Enabled = false;
            checkBoxE3.Enabled = false;
            checkBoxE4.Enabled = false;
            checkBoxE5.Enabled = false;
            checkBoxE6.Enabled = false;

            checkBoxF1.Enabled = false;
            checkBoxF2.Enabled = false;
            checkBoxF3.Enabled = false;
            checkBoxF4.Enabled = false;
            checkBoxF5.Enabled = false;
            checkBoxF6.Enabled = false;
        }

        private void ClearPasswordCheckboxes()
        {
            checkBoxA1.Checked = false;
            checkBoxA2.Checked = false;
            checkBoxA3.Checked = false;
            checkBoxA4.Checked = false;
            checkBoxA5.Checked = false;
            checkBoxA6.Checked = false;

            checkBoxB1.Checked = false;
            checkBoxB2.Checked = false;
            checkBoxB3.Checked = false;
            checkBoxB4.Checked = false;
            checkBoxB5.Checked = false;
            checkBoxB6.Checked = false;

            checkBoxC1.Checked = false;
            checkBoxC2.Checked = false;
            checkBoxC3.Checked = false;
            checkBoxC4.Checked = false;
            checkBoxC5.Checked = false;
            checkBoxC6.Checked = false;

            checkBoxD1.Checked = false;
            checkBoxD2.Checked = false;
            checkBoxD3.Checked = false;
            checkBoxD4.Checked = false;
            checkBoxD5.Checked = false;
            checkBoxD6.Checked = false;

            checkBoxE1.Checked = false;
            checkBoxE2.Checked = false;
            checkBoxE3.Checked = false;
            checkBoxE4.Checked = false;
            checkBoxE5.Checked = false;
            checkBoxE6.Checked = false;

            checkBoxF1.Checked = false;
            checkBoxF2.Checked = false;
            checkBoxF3.Checked = false;
            checkBoxF4.Checked = false;
            checkBoxF5.Checked = false;
            checkBoxF6.Checked = false;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ClearPasswordCheckboxes();

            bool hasBlizzardAttack = checkBoxBlizzardAttack.Checked;
            bool hasWindStorm = checkBoxWindStorm.Checked;
            bool hasFlameBlast = checkBoxFlameBlast.Checked;
            bool hasPlantBarricade = checkBoxPlantBarricade.Checked;
            bool hasSilverTomahawk = checkBoxSilverTomahawk.Checked;
            bool hasYamatoSpear = checkBoxYamatoSpear.Checked;
            bool hasKnightCrush = checkBoxKnightCrush.Checked;
            bool hasCentaurFlash = checkBoxCentaurFlash.Checked;

            bool hasBeatPlateB = checkBoxBeatPlateB.Checked;
            bool hasBeatPlateE = checkBoxBeatPlateE.Checked;
            bool hasBeatPlateA = checkBoxBeatPlateA.Checked;
            bool hasBeatPlateT = checkBoxBeatPlateT.Checked;

            bool hasEnergyBalancer = checkBoxEnergyBalancer.Checked;
            
            if (hasBeatPlateB && !hasSilverTomahawk)
            {
                MessageBox.Show("Selecting Beat Plate (B) requires TomahawkMan stage to be completed.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                checkBoxSilverTomahawk.Checked = true;

                return;
            }
            else if (hasBeatPlateE && !hasYamatoSpear)
            {
                MessageBox.Show("Selecting Beat Plate (E) requires YamatoMan stage to be completed.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                checkBoxYamatoSpear.Checked = true;

                return;
            }
            else if (hasBeatPlateA && !hasKnightCrush)
            {
                MessageBox.Show("Selecting Beat Plate (A) requires KnightMan stage to be completed.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                checkBoxKnightCrush.Checked = true;

                return;
            }
            else if (hasBeatPlateT && !hasCentaurFlash)
            {
                MessageBox.Show("Selecting Beat Plate (T) requires CentaurMan stage to be completed.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                checkBoxCentaurFlash.Checked = true;

                return;
            }

            if (hasEnergyBalancer)
            {
                checkBoxE5.Checked = true;

                if (hasBlizzardAttack && hasSilverTomahawk && hasBeatPlateB)
                {
                    checkBoxD2.Checked = true;
                }
                else if (hasSilverTomahawk && hasBlizzardAttack)
                {
                    checkBoxB2.Checked = true;
                }
                else if (hasSilverTomahawk && hasBeatPlateB)
                {
                    checkBoxD1.Checked = true;
                }
                else if (hasSilverTomahawk)
                {
                    checkBoxB1.Checked = true;
                }
                else if (hasBlizzardAttack)
                {
                    checkBoxA2.Checked = true;
                }
                else
                {
                    checkBoxA1.Checked = true;
                }

                if (hasWindStorm && hasYamatoSpear && hasBeatPlateE)
                {
                    checkBoxB4.Checked = true;
                }
                else if (hasWindStorm && hasYamatoSpear)
                {
                    checkBoxF2.Checked = true;
                }
                else if (hasYamatoSpear && hasBeatPlateE)
                {
                    checkBoxB3.Checked = true;
                }
                else if (hasYamatoSpear)
                {
                    checkBoxF1.Checked = true;
                }
                else if (hasWindStorm)
                {
                    checkBoxE2.Checked = true;
                }
                else
                {
                    checkBoxE1.Checked = true;
                }

                if (hasPlantBarricade && hasKnightCrush && hasBeatPlateA)
                {
                    checkBoxD6.Checked = true;
                }
                else if (hasPlantBarricade && hasKnightCrush)
                {
                    checkBoxB6.Checked = true;
                }
                else if (hasKnightCrush && hasBeatPlateA)
                {
                    checkBoxD5.Checked = true;
                }
                else if (hasKnightCrush)
                {
                    checkBoxB5.Checked = true;
                }
                else if (hasPlantBarricade)
                {
                    checkBoxA6.Checked = true;
                }
                else
                {
                    checkBoxA5.Checked = true;
                }

                if (hasFlameBlast && hasCentaurFlash && hasBeatPlateT)
                {
                    checkBoxF4.Checked = true;
                }
                else if (hasFlameBlast && hasCentaurFlash)
                {
                    checkBoxD4.Checked = true;
                }
                else if (hasCentaurFlash && hasBeatPlateT)
                {
                    checkBoxF3.Checked = true;
                }
                else if (hasCentaurFlash)
                {
                    checkBoxD3.Checked = true;
                }
                else if (hasFlameBlast)
                {
                    checkBoxC4.Checked = true;
                }
                else
                {
                    checkBoxC3.Checked = true;
                }
            }
            else
            {
                checkBoxF5.Checked = true;

                if (hasBlizzardAttack && hasSilverTomahawk && hasBeatPlateB)
                {
                    checkBoxF4.Checked = true;
                }
                else if (hasSilverTomahawk && hasBlizzardAttack)
                {
                    checkBoxB4.Checked = true;
                }
                else if (hasSilverTomahawk && hasBeatPlateB)
                {
                    checkBoxD4.Checked = true;
                }
                else if (hasSilverTomahawk)
                {
                    checkBoxE2.Checked = true;
                }
                else if (hasBlizzardAttack)
                {
                    checkBoxC2.Checked = true;
                }
                else
                {
                    checkBoxA2.Checked = true;
                }

                if (hasWindStorm && hasYamatoSpear && hasBeatPlateE)
                {
                    checkBoxD6.Checked = true;
                }
                else if (hasWindStorm && hasYamatoSpear)
                {
                    checkBoxD1.Checked = true;
                }
                else if (hasYamatoSpear && hasBeatPlateE)
                {
                    checkBoxD3.Checked = true;
                }
                else if (hasYamatoSpear)
                {
                    checkBoxB5.Checked = true;
                }
                else if (hasWindStorm)
                {
                    checkBoxB3.Checked = true;
                }
                else
                {
                    checkBoxB1.Checked = true;
                }

                if (hasPlantBarricade && hasKnightCrush && hasBeatPlateA)
                {
                    checkBoxE4.Checked = true;
                }
                else if (hasPlantBarricade && hasKnightCrush)
                {
                    checkBoxE3.Checked = true;
                }
                else if (hasKnightCrush && hasBeatPlateA)
                {
                    checkBoxC4.Checked = true;
                }
                else if (hasKnightCrush)
                {
                    checkBoxA5.Checked = true;
                }
                else if (hasPlantBarricade)
                {
                    checkBoxA4.Checked = true;
                }
                else
                {
                    checkBoxA3.Checked = true;
                }

                if (hasFlameBlast && hasCentaurFlash && hasBeatPlateT)
                {
                    checkBoxF3.Checked = true;
                }
                else if (hasFlameBlast && hasCentaurFlash)
                {
                    checkBoxE1.Checked = true;
                }
                else if (hasCentaurFlash && hasBeatPlateT)
                {
                    checkBoxF1.Checked = true;
                }
                else if (hasCentaurFlash)
                {
                    checkBoxC1.Checked = true;
                }
                else if (hasFlameBlast)
                {
                    checkBoxA1.Checked = true;
                }
                else
                {
                    checkBoxB2.Checked = true;
                }
            }
        }
    }
}
