using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustCL
{
    public partial class ctrlLogger : UserControl
    {
        string rustlocation = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\Bundles\\items";
        public ctrlLogger(string time, string attacker, string id, string target, string id2, string weapon, string ammo, string area, string distance, string oldhp, string newhp, string info)
        {
            InitializeComponent();
            label1.Text = time;
            if (attacker == "you")
            {
                label2.Text = attacker;
                label2.ForeColor = Color.Yellow;
            }
            else
            {
                label2.Text = attacker;
            }
            if (target == "you")
            {
                label3.Text = target;
                label3.ForeColor = Color.Yellow;
            }
            else
            {
                label3.Text = target;
            }
            label2.Text = attacker;
            label3.Text = target;
            label4.Text = area;
            label9.Text = distance;
            label8.Text = oldhp;
            label7.Text = newhp;
            label10.Text = info;
            if (ammo.Contains("riflebullet"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rifle.png");
            }
            else if (ammo.Contains("riflebullet_fire"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rifle.incendiary.png");
            }
            else if (ammo.Contains("riflebullet_hv"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rifle.hv.png");
            }
            else if (ammo.Contains("riflebullet_explosive"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rifle.explosive.png");
            }
            else if(ammo.Contains("shotgunslug"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.shotgun.slug.png");
            }
            else if (ammo.Contains("shotgunbullet_fire"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.shotgun.fire.png");
            }
            else if(ammo.Contains("handmade_shell"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.handmade.shell.png");
            }
            else if(ammo.Contains("nail"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.nailgun.nails.png");
            }
            else if(ammo.Contains("pistolbullet"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.pistol.png");
            }
            else if (ammo.Contains("pistolbullet_fire"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.pistol.fire.png");
            }
            else if (ammo.Contains("pistolbullet_hv"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.pistol.hv.png");
            }
            else if(ammo.Contains("arrow_bone"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\arrow.bone.png");
            }
            else if (ammo.Contains("arrow_fire"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\arrow.fire.png");
            }
            else if(ammo.Contains("arrow_hv"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\arrow.hv.png");
            }
            else if(ammo.Contains("arrow_wooden"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\arrow.wooden.png");
            }
            else if (ammo.Contains("rocket_basic"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rocket.basic.png");
            }
            else if (ammo.Contains("rocket_fire"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rocket.fire.png");
            }
            else if (ammo.Contains("rocket_hv"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rocket.hv.png");
            }
            else if (ammo.Contains("rocket_smoke"))
            {
                pictureBox2.Image = Image.FromFile(rustlocation + "\\ammo.rocket.smoke.png");
            }
            else
            {

            }
            if (weapon.Contains("ak"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rifle.ak.png");
            }
            else if (weapon.Contains("bolt"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rifle.bolt.png");
            }
            else if (weapon.Contains("smg"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\smg.2.png");
            }
            else if (weapon.Contains("beancan"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\grenade.beancan.png");
            }
            else if (weapon.Contains("semi_auto_rifle"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rifle.semiauto.png");
            }
            else if (weapon.Contains("pistol_semiauto"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pistol.semiauto.png");
            }
            else if (weapon.Contains("bone_club"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\bone.club.png");

            }
            else if (weapon.Contains("knife_bone"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\knife.bone.png");
            }
            else if (weapon.Contains("butcherknife"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\knife.butcher.png");
            }
            else if (weapon.Contains("knife.combat"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\knife.combat.png");

            }
            else if (weapon.Contains("candy_cane"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\candycaneclub.png");
            }
            else if (weapon.Contains("compound_bow"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\bow.compound.png");
            }
            else if (weapon.Contains("bow_hunting"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\bow.hunting.png");
            }
            else if (weapon.Contains("crossbow"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\crossbow.png");
            }
            else if (weapon.Contains("double_shotgun"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\shotgun.double.png");
            }
            else if (weapon.Contains("pistol_eoka"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pistol.eoka.png");
            }
            else if (weapon.Contains("grenade.f1"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\grenade.f1.png");
            }
            else if (weapon.Contains("flamethrower"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\flamethrower.png");
            }
            else if (weapon.Contains("l96"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rifle.l96.png");
            }
            else if (weapon.Contains("lr300"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rifle.lr300.png");
            }
            else if (weapon.Contains("longsword"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\longsword.png");
            }
            else if (weapon.Contains("m249"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\lmg.m249.png");
            }
            else if (weapon.Contains("m39"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rifle.m39.png");
            }
            else if (weapon.Contains("m92"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pistol.m92.png");
            }
            else if (weapon.Contains("mp5"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\smg.mp5.png");
            }
            else if (weapon.Contains("mace"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\mace.png");
            }
            else if (weapon.Contains("machete"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\machete.png");
            }
            else if (weapon.Contains("mgl"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\multiplegrenadelauncher.png");
            }
            else if (weapon.Contains("nailgun"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pistol.nailgun.png");
            }
            else if (weapon.Contains("paddle"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\paddle.png");
            }
            else if (weapon.Contains("pitchfork"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pitchfork.png");
            }
            else if (weapon.Contains("shotgun_pump"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\shotgun.pump.png");
            }
            else if (weapon.Contains("python"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pistol.python.png");
            }
            else if (weapon.Contains("pistol_revolver"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pistol.revolver.png");
            }
            else if (weapon.Contains("rocket_basic"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rocket.launcher.png");
            }
            else if (weapon.Contains("salvaged_cleaver"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\salvaged.cleaver.png");
            }
            else if (weapon.Contains("salvaged_sword"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\salvaged.sword.png");
            }
            else if (weapon.Contains("snowball"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\snowball.png");
            }
            else if (weapon.Contains("snowballgun"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\snowballgun.png");
            }
            else if (weapon.Contains("spas12"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\shotgun.spas12.png");
            }
            else if (weapon.Contains("spear_stone"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\spear.stone.png");
            }
            else if (weapon.Contains("spear_wooden"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\spear.wooden.png");
            }
            else if (weapon.Contains("thompson"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\smg.thompson.png");
            }
            else if (weapon.Contains("watergun"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\gun.water.watergun.green.png");
            }
            else if (weapon.Contains("waterpistol"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pistol.water.png");
            }
            else if (weapon.Contains("shotgun_waterpipe"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\shotgun.waterpipe.png");
            }
            else if (weapon.Contains("cake"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\cakefiveyear.png");
            }
            else if (weapon.Contains("chainsaw"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\chainsaw.png");
            }
            else if (weapon.Contains("flashlight"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\flashlight.held.png");
            }
            else if (weapon.Contains("hatchet"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\hatchet.png");
            }
            else if (weapon.Contains("jackhammer"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\jackhammer.png");
            }
            else if (weapon.Contains("pickaxe.entity"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\pickaxe.png");
            }
            else if (weapon.Contains("rock.entity"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\rock.png");
            }
            else if (weapon.Contains("axe_salvaged"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\axe.salvaged.png");
            }
            else if (weapon.Contains("hammer_salvaged"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\hammer.salvaged.png");
            }
            else if (weapon.Contains("icepick_salvaged"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\icepick.salvaged.png");
            }
            else if (weapon.Contains("explosive.satchel"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\explosive.satchel.png");
            }
            else if (weapon.Contains("stone_pickaxe"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\stone.pickaxe.png");
            }
            else if (weapon.Contains("survey_charge"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\surveycharge.png");
            }
            else if (weapon.Contains("explosive.timed.deployed"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\explosive.timed.png");
            }
            else if (weapon.Contains("torch.entity"))
            {
                pictureBox1.Image = Image.FromFile(rustlocation + "\\torch.png");
            }
            else
            { }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
