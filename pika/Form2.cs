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
        private readonly SoundPlayer soundPok = new SoundPlayer(Resources.Pokemon_minus);
        private readonly SoundPlayer soundRock = new SoundPlayer(Resources.RocketTeam);
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
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox1, "ЭШ КЕТЧУМ - тренер покемонов \nЕго заветная мечта — стать самым величайшим Мастером Покемонов в мире.");
            pictureBox26.Image = Resources.PictureBox1;
            ForLeft();
        }

        void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox26.Visible = false;
            soundPok.Stop();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox2, "МИСТИ - подруга Эша Кетчума, тренер покемонов. \nЭш считает ее одним из своих лучших друзей." +
                "\nУ Мисти зелёные глаза и рыжие короткие волосы, которые она собирает в хвост на левом боку. " +
                "\nНосит короткую майку жёлтого цвета, открывающую её живот и джинсовые шортики на подтяжках. На ногах - красно-белые кроссовки с жёлтым узором." +
                "\nХарактер у Мисти весёлый и оптимистичный, но довольно-таки вспыльчивый. Не может смириться с популярностью её сестёр, а Псайдак сводит её с ума. " +
                "\nДо ужаса боится покемонов-насекомых (особенно червей) и призраков, хотя Ледиба, Баттерфри и Бьютифлай ей очень нравятся. " +
                "\nНо когда речь идёт о водных покемонах, тут она готова говорить сколько угодно долго, т. к. считает их всех симпатичными (кроме Псайдака и Гаярадоса).");
            pictureBox26.Image = Resources.PictureBox2;
            ForLeft();
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox3, "Эш и БРОК - лучшие друзья \nтренер покемонов \nВо время своих путешествий Эш стал считать Брока своим старшим братом");
            pictureBox26.Image = Resources.PictureBox3;
            ForLeft();
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox4, "ДЖЕССИ - сильнейший член команды Р, смелый, не останавливающийся перед препятствиями тренер. " +
                "\nГде бы не случился бой, она и её Эрбок первые бросаются в атаку. " +
                "\nНесмотря на красоту и интеллигентность, Джесси любит дать выход своей ярости, она агрессивна и тяжела на руку. " +
                "\nДжесси честная и прямолинейная, всегда говорит правду в глаза, даже если это может грозить ей большими неприятностями. " +
                "\nОна - пример женщины, сильной, умной и красивой одновременно. Джесси может казаться жестокой и беспринципной.");
            pictureBox25.Image = Resources.PictureBox4;
            ForRight();
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox5, "Если Мяут - мозг команды Р, а Джесси - мускулы, то ДЖЕЙМС - её сердце. Джеймс очень чувствителен. " +
                "\nОн прекрасно видит и понимает все эмоции своих друзей, всегда вежлив и сдержан, всегда утешает Джесси, когда она вспоминает о своём прошлом, всегда приходит на помощь Мяуту. " +
                "\nДжеймс любит розы. Когда ему удаётся, он держит розу при произнесении девиза команды R. Роза - цветок красоты и любви, но у неё есть шипы. Для Джеймса она - символ Джесси. " +
                "\nДжеймс доброжелателен и всегда склонен видеть в людях самое лучшее. Может показаться, что он доверчив и даже наивен, но это не делает его глупым. " +
                "\nНаоборот, он очень умён, прекрасно разбирается в компьютерах, механике, знает всё о садоводстве и покемоноводстве. " +
                "\nДжеймс не очень сильный тренер, он не любит сражений, а любимой его атакой является дымовая завеса, позволяющая команде R беспрепятственно обделывать свои дела. " +
                "\nНо тот, кто сочтёт Джеймса слабаком, очень ошибётся: когда действительно необходимо, Джеймс превращается в сильного и жестокого бойца, а его покемоны, Визинг и Виктрибелл, в неуязвимых монстров. " +
                "\nК счастью для врагов, подобная трансформация крайне редка. Джеймс - наиболее уравновешенный член команды, у Джесси и Мяута он нашёл понимание и дружбу - то, что он искал, убегая из дома. " +
                "\nИ хотя он всё ещё мечтает о богатстве и успехе, он не видит себя без друзей. Для него - Команда R - это больше, чем команда. Это его семья. ");
            pictureBox25.Image = Resources.PictureBox5;
            ForRight();
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox6, "МЯУТ - неофициальный талисман команды R. " +
                "\nОн путешествует вместе с Джесси и Джеймсом. Мяут - сам себе покемон и тренер." +
                "\nБудучи, вероятно, умнейшим членом команды, он придумывает большинство зловещих планов, заставляя друзей следовать им. " +
                "\nНо его редко слушают, поэтому ему приходится часто пускать в ход свои когти. -Острей моих когтей - только мой ум - его личный девиз.");
            pictureBox25.Image = Resources.PictureBox6;
            ForRight();
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
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
            pictureBox26.Image = Resources.PictureBox7;
            ForLeft();
        }

        private void PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox8, "ПСАЙДАК -  покемон водного типа. Внешне он похож на утконоса, но его задние лапы, как у утки. На голове у него торчат три чёрных волоска. У Псайдака постоянный отсутствующий взгляд. " +
                "Псайдаки живут в озёрах, небольших прудах, реках с чистой водой. В основном, встречаются в тёплых областях. Поймать дикого псайдака можно без проблем во всех известных регионах в зонах Сафари." +
                "\nХарактер Псайдака - очень добрый и наивный, из-за его глуповатости он кажется совсем не мыслящим, но это не так - он очень предан своему тренеру, хоть и прожорлив." +
                "\nПри сильной головной боли появляется невероятно мощная атака.");
            pictureBox26.Image = Resources.PictureBox8;
            ForLeft();
        }

        private void PictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox9, "ОНИКС -  покемон двойного каменного/земляного типа. Оникс - это огромный покемон, похожий на каменную змею. " +
                "\nОн третий по длине среди всех покемонов, длиннее только стиликс и вэйлорд. Голова у оникса чем-то похожа на акулью, возможно, из огромного плавника на макушке. " +
                "\nТело состоит из более, чем десяти камней неровной, округлой формы, чем ближе к хвосту, тем меньше размеры камня. " +
                "\nПо мере роста оникса эти камни становятся все твёрже, прямо как алмазы, только чёрные. Кроме того, тело оникса при трении об землю шлифуется, камни становятся всё более круглыми и гладкими. " +
                "\nПитается оникс камнями, считается, что за счёт этого у оникса такое прочное тело. В мозгу оникса находится магнит, он служит для покемона компасом." +
                "\nБлагодаря этому оникс, даже находясь в полной темноте глубоко под землёй, всегда знает, в каком направлении надо двигаться. Передвигается он как змея. " +
                "\nБыл самым крупным покемоном которого можно получить из яйца." +
                "\nЭто весьма вспыльчивый и грозный покемон. Он не любит, когда его тревожат или заходят на его территорию. Он легко впадает в ярость. " +
                "\nОднако домашние ониксы достаточно миролюбивы.Они могут играть с детьми и перевозить на себе людей.Как и все каменные покемоны, ониксы боятся воды.");
            pictureBox26.Image = Resources.PictureBox9;
            ForLeft();
        }

        private void PictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox10, "АРБОК - это покемон-кобра фиолетового цвета. На животе причудливые узоры в виде глаз и рта. Они служат предупреждением для людей и других покемонов, что эрбок ядовит. " +
                "\nБыло найдено шесть вариаций узоров, они меняются в зависимости от места обитания покемона. По сравнению с прошлой эволюцией, арбок стал короче, но гораздо сильнее. " +
                "\nИсчезла погремушка на конце хвоста.Удивительно мстительный покемон, будет до конца преследовать противника, будь то враг или добыча.Однако он не забудет добро." +
                "\nЧтобы испугать добычу, арбок раздувает свой капюшон и издает жуткие шипящие звуки. Увидев узор а-ля страшная морда на животе арбока, жертва пугается и застывает в ужасе, а змея охватывает добычу и раздавливает, либо добивает ядовитым укусом. " +
                "\nАрбок настолько силён, что может раздавить стальную цистерну. Способен атаковать электрическими иглами. Также арбок может прожигать кислотой препятствия, что позволяет ему пробираться даже в непроходимых местах.");
            pictureBox25.Image = Resources.PictureBox10;
            ForRight();
        }

        private void PictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox11, "КОФФИНГ - покемон в виде шара, который выпускают газы из многих отверстий на его теле. Под его лицом (на котором застыла улыбка) располагается бежевый рисунок в виде черепа с двумя с костями и одной глазницей. " +
                "\nСам покемон фиолетового цвета. По улыбке Коффинга можно предположить, что он всегда рад и любопытен всему и везде, даже если его ударил другой покемон. Коффинг способен парить над землёй (у него нет ног), несмотря на то, что он не летающего типа. " +
                "\nТакже способен выпускать различные газы, начиная от обычной дымовой завесы и усыпляющих газов, заканчивая смертельно опасными газами.");
            pictureBox25.Image = Resources.PictureBox11;
            ForRight();
        }

        private void PictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox12, "ВИКТРИБЕЛ - единственный в своей эволюционной семье, имеющий видимые зубы. Два острых зуба расположены у его большого рта. Его глаза расположены прямо под губами. " +
                "\nУ него есть две лозы, одна с большим листом, а другая с лампочкой в конце. У всех Виктрибелов есть способность Хлорофилл. Хлорофилл увеличивает скорость Виктрибела, когда солнце отсутствует. " +
                "\nВиктрибел заманивает свою добычу, испуская сладкий запах. Когда покемон входит в рот Виктрибела, он проглатывается целиком. Хотя этот покемон может показаться страшным, на самом деле у него добродушный характер. " +
                "\nТак он может хватать тренера, но это лишь проявление симпатии.");
            pictureBox25.Image = Resources.PictureBox12;
            ForRight();
        }

        private void PictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox13, "ЧАРМАНДЕР представляет собой двуногую рептилию красновато-оранжевого цвета, с голубыми глазами и кремовым брюшком. Внешне Чармандер похож на динозавра." +
                "\nНа кончике хвоста у него горит пламя. Это пламя горит у него с самого рождения. Говорят, что если огонь потухнет, Чармандер умрёт. Размер пламени зависит от здоровья Чармандера. Пламя горит со звуком, с которым горит костёр. " +
                "\nНо услышать его можно только при полной тишине. В отличие от обычного пламени, пламя на кончике его хвоста погасить очень сложно, иначе Чармандер погибал бы при любой водной или ледяной атаке." +
                "\nПо сравнению со своими эволюциями Чармандер очень спокойный и милый. По огоньку на хвосте можно судить о его настроении. Например, если он злится, пламя становится больше. В природе встречается довольно редко.");
            pictureBox26.Image = Resources.PictureBox13;
            ForLeft();
        }

        private void PictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox14, "ТОГЕПИ - это покемон, который, похоже, еще не полностью вылупился из своей оболочки; только его голова и короткие руки и ноги появляются из оболочки его яйца. " +
                "\nЧасти его тела, которые появляются имеют бледный, кремовый цвет, в то время как оболочка преимущественно белая. " +
                "\nСкорлупа Тогепи также имеет красные и синие знаки, в форме треугольника. Его голова имеет пять шипов, которые образуют корону. Глаза маленькие, черные, овальной формыУ Тогепи очень радостный характер. " +
                "\nВ результате, говорят, что он разделяет свою радость с теми, кто заботится о нем. Из-за своего расположения, Тогепи рассматривается как знак удачи, особенно если тренер способен заставить спящего Тогепи стоять." +
                "\nСкорлупа Тогепи наполнена феромонами счастья, которым он делится с добросердечными людьми. И если с Тогепи хорошо обращаются, его успокаивающая аура, которую он распространяет, усиливается. " +
                "\nНесмотря на редкость в дикой природе, Тогепи чаще всего можно найти в лесах. Но у тогепи есть собственный мир, где они обитают.");
            pictureBox26.Image = Resources.PictureBox14;
            ForLeft();
        }

        private void PictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox15, "СКВИРТЛ — это небольшая черепашка с кожей голубого цвета. У него круглый коричневый панцирь с жёлтым брюшком. На панцире узоры шестиугольной формы. Сбоку панцирь имеет окантовку белого цвета. " +
                "\nУ Сквиртла четыре лапки одинаковой длины. Передвигается он на двух задних. Хоть это и водный покемон, он прекрасно себя чувствует и на суше вдали от водоёмов. При рождении у Сквиртла мягкий панцирь, который постепенно начинает твердеть. " +
                "\nВ итоге панцирь становится достаточно крепким, чтобы стать хорошей защитой для хозяина. Хвост у него длиннее, чем у реальных черепах, с его помощью он производит атаки, как хвост-кнут и водяной хвост." +
                "\nУ сквиртла довольно спокойный характер, хотя иногда его сложно контролировать. В этом отношении его труднее тренировать, чем Бульбазавра, но легче, чем Чармандера. Сквиртл очень привязан к своим сородичам. " +
                "\nНо, тем не менее, он хорошо ладит и с другими видами покемонов. Дикие Сквиртлы довольно недоверчивы по отношению к людям. Сквиртлы и Пикачу могут стать хорошими друзьями.");
            pictureBox26.Image = Resources.PictureBox15;
            ForLeft();
        }

        private void PictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox16, "ЛИКИТУНГА можно отнести к рептилиям. У него розовый окрас тела, но на животе есть желтые полоски, а на коленях круги. Он очень толстый, из-за чего кажется неуклюжим. " +
                "\nЛикитунг всегда ходит в высунутым языком, который достается чуть ли не до самой земли. Хвост у покемона тоже длинный и очень пушистый. Глаза у Ликитунга - маленькие черненькие бусинки, нос такой же маленький." +
                "\nПокемон несколько ленивый, у него немного замедленная реакция на происходящее вокруг. Благодаря своему языку он может зализать своего противника до смерти. Также им он ловит свою добычу, так как слюна обладает клейким свойством. " +
                "\nОн очень часто может быть увлечен каким-то действием, что не обращается на происходящее вокруг него, поэтому к нему незаметно может подкрасться противник. Ликитунг обитает на открытых равнинах, в полях, очень редко их можно встретить возле водоемов, в лесах и даже городах.");
            pictureBox25.Image = Resources.PictureBox16;
            ForRight();
        }

        private void PictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox17, "ГРОУЛИТ довольно-таки большой покемон. Похож на собаку. У него тигриная расцветка шкуры. Шерсть на животе груди и мордочке имеет белый цвет. Такой же белоснежный у покемона пушистый хвост и маленький хохолок на голове. " +
                "\nНос у Гроулита чёрный и блестящий. Цвет глаз - темный. Дополняют картину два круглых уха. Вооружен покемон острыми клыками и когтями (по три на каждой лапе). На лапках у него розовые подушечки. Такой же цвет и у языка покемона." +
                "\nОчень дружелюбный покемон. Гроулиты хорошо известны своей храбростью и удивительной верностью. При необходимости без проблем бросит вызов и более сильному противнику. В кусательный режим переключается только при вторжении чужого на охраняемую покемоном территорию или при нападении на тренера. " +
                "\nРади тренера покемон готов и жизнью пожертвовать. Благодаря этим качествам гроулит стал основным покемоном - помощником полицейских, а также он хорошо подходит для возни с детьми." +
                "\nГроулиты активно идут в атаку в битве. Хорошо действуют в команде. Они узнают хозяина по голосу. Его сверхчутье позволяет Гроулиту запоминать совершенно любой запах, будь то противник или потерявшийся человек или покемон. Он использует обоняние для определения чужого настроения. " +
                "\nГроулиты воздерживаются от атаки, если видят, что их противник сдался.При коллективном бое окружают соперника, лишая его возможности сбежать.При ближних атаках орудуют клыками, реже когтями.Могут применить и огненную струю.Своим громким голосом Гроулиты могут оглушить или обескуражить противника. " +
                "\nОбычно рычания и разъяренного взгляда хватает для запугивания.");
            pictureBox25.Image = Resources.PictureBox17;
            ForRight();
        }

        private void PictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox18, "РАТИКЭЙТ — покемон-крыса. Шерсть у него в основном коричневого цвета, лишь чуть светлее она на брюхе. Лапки короткие, с тремя когтистыми пальчиками; хвост, как у его прообраза - крысы, длинный и не покрыт шерстью. " +
                "\nНа голове расположены глаза, уши, нос, усы и рот с большими резцами, характерными для грызунов. Зубы у ратикэйта растут постоянно, поэтому он вечно грызёт, чтобы резцы стирались и оставались положенной длины. Грызёт он всё подряд от коры до камней. " +
                "\nДлинные усы на морде нужны для равновесия.Без них ратикэйт будет двигаться медленнее, боясь упасть.У самок усы короче и шерсть светлее, чем у самцов.На задних лапках есть перепонки, с их помощью ратикэйт отлично плавает в воде, так он и за рыбой охотится и реки переплывает в поисках пищи на другом берегу." +
                "\nГлавное оружие ратикэйта - его зубы. При приближении опасности ратикэйт встаёт на задние лапки и начинает щёлкать огромными резцами, чтобы запугать противника. Резцы эти настолько крепкие, что ратикэйт может прогрызть бетонную стену. Много зданий обвалилось из-за ратикэйтов, испортивших фундамент.");
            pictureBox25.Image = Resources.PictureBox18;
            ForRight();
        }

        private void PictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox19, "Исследователи не уверены, классифицировать БУЛЬБАЗАВРА как растение или животное. Он по сути представляет собой что-то среднее между динозавром дицинодонтом и жабой." +
                "\n Бульбазавры ходят на четырёх лапах, но могут встать и на две. С эволюцией они теряют эту способность, из-за того, что цветок на спине становится слишком тяжелым. Именно поэтому у эволюций бульбазавра скорость намного меньше." +
                "\nЛуковица наполнена питательными веществами. Первое время новорожденный бульбазавр живёт исключительно за счёт этого запаса. Бульбазавр может вообще не есть, а жить исключительно за счёт фотосинтеза или энергии, запасённой в луковице. С рождения у бульбазавра на спине прорастает семя. " +
                "\nОно становится луковицей, которая растёт вместе с покемоном. С её помощью покемон может поглощать солнечный свет и перерабатывать в питательные вещества. Также луковица отвечает за многие атаки покемона. Бульбазавр и растение живут в симбиозе. " +
                "\nТакже в луковице находятся семена, пыльца, и от неё растут лианы, используемые в бою и для перемещения.  бульбазавра покладистый характер, благодаря чему он хорош для начинающих тренеров. Бульбазавр хорошо ладит с другими покемонами и в случае необходимости может взять на себя роль лидера." +
                "\nУ диких бульбазавров сложное сообщество со своими традициями и ритуалами, и они стоят горой за любого бульбазавра, даже чужака.");
            pictureBox26.Image = Resources.PictureBox19;
            ForLeft();
        }

        private void PictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox20_MouseEnter(object sender, EventArgs e)
        {
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox20, "СТАРМИ — покемон-звезда двойного типа — водного и психического. Ядро Старми светится всеми семью цветами радуги, поэтому многие считают его драгоценным камнем. Считается, что с помощью этого мигания Старми общаются между собой. Старми посылает своим мерцанием сигналы в космос. " +
                "\nВне зависимости от условий окружающей среды этот покемон всегда вырастает идеально симметричным.");
            pictureBox26.Image = Resources.PictureBox20;
            ForLeft();
        }

        private void PictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            soundPok.Play();
            toolTip1.SetToolTip(pictureBox21, "ГОЛДИН - похож на рыбу покемона с длинными вздымающимися плавниками. Он окрашен в оранжевый и белый. Голдин также имеет рог на своем лбу, который он использует для атаки противников." +
                "\nНа вид красивый покемон, которого легко заманить к себе. Однако Голдин агрессивно настроена к каждому, кто приближается к ней.");
            pictureBox26.Image = Resources.PictureBox21;
            ForLeft();
        }

        private void PictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            soundPok.Stop();
            pictureBox26.Visible = false;
        }

        private void PictureBox22_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox22, "ВОББАФЕТ — психический покемон. У него тело светло-синего цвета и чёрный хвост. Глаза воббафета как будто закрыты, а рот похож на зигзаг. У воббафета пара рук и четыре маленькие ножки." +
                "\nХоть воббафет достаточно вынослив, он не любит, когда его шокируют. Если на него нападают, то он лишь отражает атаки контр-атакой. Но если противник атакует его хвост, который очень ценен для покемона (не ясно почему), то покемон применит Связь Судьбы. При встрече двух воббафетов может произойти поединок выносливости." +
                "\nУвы, но выдающими способностями он не блещет. Главная способность этого покемона - отражать чужие атаки. Поэтому он знает всего два типа защиты - от физического и от особого урона.");
            pictureBox25.Image = Resources.PictureBox22;
            ForRight();
        }

        private void PictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox23_MouseEnter(object sender, EventArgs e)
        {
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox23, "КАКНЕЯ — это покемон травяного типа под номером 331 в Покедекс. Он эволюционирует в Кактурна. Какнея живет в засушливых местах и пустынях.Он выделяет сильный аромат из цветка для привлечения добычи." +
                "\nМонстр выстреливает острыми шипами из тела в жертву.Этим он пытается повалить противника на землю.");
            pictureBox25.Image = Resources.PictureBox23;
            ForRight();
        }

        private void PictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }

        private void PictureBox24_MouseEnter(object sender, EventArgs e)
        {
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            soundRock.Play();
            toolTip1.SetToolTip(pictureBox24, "ДРОУЗИ — человекообразный покемон психического типа. Своей мордой напоминает тапира. Дроузи ходит на двух ногах, как человек, руки свисают вдоль боков. " +
                "\nПредставляет собой тучное и неповоротливое создание с вечно отсутствующим взглядом. Верхняя часть тела покемона желтая, а нижняя — грязно-коричневая. Покемон трехпалый, нижние лапы с когтями. Глаза белые. " +
                "\nЕго прообразом был Баку - мифическое существо, пожирающие плохие сны, основанное на малайском чепрачном тапире. " +
                "\nЧешется нос во время сна? Это верный признак присутствия рядом Дроузи. Покемон может встать рядом с подушкой человека и воровать его сновидения через нос.");
            pictureBox25.Image = Resources.PictureBox24;
            ForRight();
        }

        private void PictureBox24_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
            soundRock.Stop();
            pictureBox25.Visible = false;
        }
       
       void ForLeft()
        {
            pictureBox26.Visible = true;
            pictureBox4.SendToBack();
            pictureBox5.SendToBack();
            pictureBox6.SendToBack();
            pictureBox10.SendToBack();
            pictureBox11.SendToBack();
            pictureBox12.SendToBack();
            pictureBox16.SendToBack();
            pictureBox17.SendToBack();
            pictureBox18.SendToBack();
            pictureBox22.SendToBack();
            pictureBox23.SendToBack();
            pictureBox24.SendToBack();
        }

        void ForRight()
        {
            pictureBox25.Visible = true;
            pictureBox1.SendToBack();
            pictureBox2.SendToBack();
            pictureBox3.SendToBack();
            pictureBox7.SendToBack();
            pictureBox8.SendToBack();
            pictureBox9.SendToBack();
            pictureBox13.SendToBack();
            pictureBox14.SendToBack();
            pictureBox15.SendToBack();
            pictureBox19.SendToBack();
            pictureBox20.SendToBack();
            pictureBox21.SendToBack();
        }
    }
}
