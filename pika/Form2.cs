using pika.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace pika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        void Global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }


        void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox1, "ЭШ КЕТЧУМ - тренер покемонов \nЕго заветная мечта — стать самым величайшим Мастером Покемонов в мире.");
                      
        }

        void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox2, "МИСТИ - подруга Эша Кетчума, тренер покемонов. \nЭш считает ее одним из своих лучших друзей." +
                "\nУ Мисти зелёные глаза и рыжие короткие волосы, которые она собирает в хвост на левом боку. " +
                "\nНосит короткую майку жёлтого цвета, открывающую её живот и джинсовые шортики на подтяжках. На ногах - красно-белые кроссовки с жёлтым узором." +
                "\nХарактер у Мисти весёлый и оптимистичный, но довольно-таки вспыльчивый. Не может смириться с популярностью её сестёр, а Псайдак сводит её с ума. " +
                "\nДо ужаса боится покемонов-насекомых (особенно червей) и призраков, хотя Ледиба, Баттерфри и Бьютифлай ей очень нравятся. " +
                "\nНо когда речь идёт о водных покемонах, тут она готова говорить сколько угодно долго, т. к. считает их всех симпатичными (кроме Псайдака и Гаярадоса).");
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox3, "Эш и БРОК - лучшие друзья \nтренер покемонов \nВо время своих путешествий Эш стал считать Брока своим старшим братом");
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox4, "ДЖЕССИ - сильнейший член команды Р, смелый, не останавливающийся перед препятствиями тренер. " +
                "\nГде бы не случился бой, она и её Эрбок первые бросаются в атаку. " +
                "\nНесмотря на красоту и интеллигентность, Джесси любит дать выход своей ярости, она агрессивна и тяжела на руку. " +
                "\nДжесси честная и прямолинейная, всегда говорит правду в глаза, даже если это может грозить ей большими неприятностями. " +
                "\nОна - пример женщины, сильной, умной и красивой одновременно. Джесси может казаться жестокой и беспринципной.");
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();

        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox5, "Если Мяут - мозг команды Р, а Джесси - мускулы, то ДЖЕЙМС - её сердце. Джеймс очень чувствителен. " +
                "\nОн прекрасно видит и понимает все эмоции своих друзей, всегда вежлив и сдержан, всегда утешает Джесси, когда она вспоминает о своём прошлом, всегда приходит на помощь Мяуту. " +
                "\nДжеймс любит розы. Когда ему удаётся, он держит розу при произнесении девиза команды R. Роза - цветок красоты и любви, но у неё есть шипы. Для Джеймса она - символ Джесси. " +
                "\nДжеймс доброжелателен и всегда склонен видеть в людях самое лучшее. Может показаться, что он доверчив и даже наивен, но это не делает его глупым. " +
                "\nНаоборот, он очень умён, прекрасно разбирается в компьютерах, механике, знает всё о садоводстве и покемоноводстве. " +
                "\nДжеймс не очень сильный тренер, он не любит сражений, а любимой его атакой является дымовая завеса, позволяющая команде R беспрепятственно обделывать свои дела. " +
                "\nНо тот, кто сочтёт Джеймса слабаком, очень ошибётся: когда действительно необходимо, Джеймс превращается в сильного и жестокого бойца, а его покемоны, Визинг и Виктрибелл, в неуязвимых монстров. " +
                "\nК счастью для врагов, подобная трансформация крайне редка. Джеймс - наиболее уравновешенный член команды, у Джесси и Мяута он нашёл понимание и дружбу - то, что он искал, убегая из дома. " +
                "\nИ хотя он всё ещё мечтает о богатстве и успехе, он не видит себя без друзей. Для него - Команда R - это больше, чем команда. Это его семья. ");
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop(); ;
        }

        private void PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox6, "МЯУТ - неофициальный талисман команды R. " +
                "\nОн путешествует вместе с Джесси и Джеймсом. Мяут - сам себе покемон и тренер." +
                "\nБудучи, вероятно, умнейшим членом команды, он придумывает большинство зловещих планов, заставляя друзей следовать им. " +
                "\nНо его редко слушают, поэтому ему приходится часто пускать в ход свои когти. -Острей моих когтей - только мой ум - его личный девиз.");
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox7, "ПИКАЧУ - покемон электрического типа. " +
                "\nСначала между Эшем и Пикачу были напряжённые отношения, особенно из-за того, что Пикачу не хотел сидеть в покеболе, а Эш привык к тому, что покемоны выходят наружу только по приказу. " +
                "\nНо впоследствии они подружились и с тех пор путешествуют вместе." +
                "\nПикачу - небольшой покемон жёлтого цвета. Он считается мышью или белкой, но внешне он больше похож на кролика. У него длинные, очень чуткие уши, и длинный зигзагообразный хвост. " +
                "\nОн похож на молнию, а молния связана с электричеством... Кончики ушей у него чёрного цвета, на спине есть две тёмно-коричневые полоски. " +
                "\nТакого же тёмно-коричневого цвета у него основание хвоста. У пикачу четыре довольно короткие лапки, что не мешает ему развивать большую скорость и делать длинные прыжки. " +
                "\nПередвигается, в основном, на всех четверых. Но, при желании, способен ходить и на двух задних. На мордочке у пикачу два круглых тёмно-коричневых глаза, малюсенький чёрный носик и ротик с типичной заячьей губой. " +
                "\nЩёчки выделены красным кругом. Известно, что именно в защёчных кармашках у него вырабатывается электричество." +
                "\nПикачу — спокойные и добрые покемоны. Они хорошо общаются между собой, легко привыкают к другим покемонам. " +
                "\nОчень дружны со своими тренерами. Но если пикачу или его товарищу, будет грозить опасность, пикачу, не раздумывая, ринется в бой, используя электричество, удары хвоста и укусы острых зубов. " +
                "\nИ, например, если потянуть его за хвост, то пикачу больно ударит током. Пикачу лучше не пугать, ведь группа этих покемонов может выработать такой мощный разряд, что начнётся гроза. " +
                "\nДикие пикачу в лесах не очень ладят с людьми и предпочитают не попадаться им на глаза.  ");
        }

        private void PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox8, "ПСАЙДАК -  покемон водного типа. Внешне он похож на утконоса, но его задние лапы, как у утки. На голове у него торчат три чёрных волоска. У Псайдака постоянный отсутствующий взгляд." +
                "\nХарактер Псайдака - очень добрый и наивный, из-за его глуповатости он кажется совсем не мыслящим, но это не так - он очень предан своему тренеру, хоть и прожорлив." +
                "\nПри сильной головной боли появляется невероятно мощная атака. " +
                "\nПри сильной головной боли появляется невероятно мощная атака.");
        }

        private void PictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox9, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox10, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox11, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox12, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox13, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox14, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox15, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox16, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox17, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox18, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox19, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox20_MouseEnter(object sender, EventArgs e)
        {
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox20, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            SpPokStart();
            toolTip1.SetToolTip(pictureBox21, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            SpPokStop();
        }

        private void PictureBox22_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox22, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox23_MouseEnter(object sender, EventArgs e)
        {
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox23, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }

        private void PictureBox24_MouseEnter(object sender, EventArgs e)
        {
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            SpRstart();
            toolTip1.SetToolTip(pictureBox24, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nЭш считает ее одним из своих лучших друзей.");
        }

        private void PictureBox24_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
            SpRstop();
        }


        void SpPokStart()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Pokemon_minus);
            simpleSound.Play();
        }

        void SpPokStop()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Pokemon_minus);
            simpleSound.Stop();
        }

        void SpRstart()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.RocketTeam);
            simpleSound.Play();
        }

        void SpRstop()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.RocketTeam);
            simpleSound.Stop();
        }
    }
}
