﻿#region
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion
/// <summary>
/// Change namespace !!!
/// </summary>
namespace DataBaseUsers
{
    public static class TextBoxWatermarkExtensionMethod
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)] private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public static void SetWatermark(this TextBox textBox, string watermarkText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }
        public static string m3u1 = "#EXTM3U url-tvg=\"http://www.teleguide.info/download/new3/jtv.zip\""
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Звезда"
        + "https://strm.yandex.ru/kal/zvezda_supres/zvezda_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",РБК"
        + "https://strm.yandex.ru/kal/rbc_supres/rbc_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",МУЗ ТВ"
        + "https://strm.yandex.ru/kal/muztv_supres/muztv_supres0_1511_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Футбол"
        + "https://strm.yandex.ru/kal/football/football0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",RUTV"
        + "https://strm.yandex.ru/kal/rutv_cv/rutv_cv0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Охотник и Рыболов"
        + "https://strm.yandex.ru/kal/ohotnik/ohotnik0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Совершенно секретно"
        + "https://strm.yandex.ru/kal/sovsec_supres/sovsec_supres0_54_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",1HD"
        + "https://strm.yandex.ru/kal/1hd/1hd0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",360°"
        + "https://strm.yandex.ru/kal/360tv_ac/360tv_ac0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",360° Новости"
        + "https://strm.yandex.ru/kal/360news/360news0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",8-ой Канал Красноярск"
        + "https://strm.yandex.ru/kal/ch8/ch80_43_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Аист"
        + "https://strm.yandex.ru/kal/aist/aist0_43_540p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Анекдот ТВ"
        + "https://strm.yandex.ru/kal/anekdot/anekdot0_1511_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Архыз 24"
        + "https://strm.yandex.ru/kal/arhyz24/arhyz240_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Астрахань 24"
        + "https://strm.yandex.ru/kal/astrahan24/astrahan240_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Баланс ТВ"
        + "https://strm.yandex.ru/kal/balancetv/balancetv0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Башкортостан 24"
        + "https://strm.yandex.ru/kal/bashkortostan24/bashkortostan240_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Большая Азия"
        + "https://strm.yandex.ru/kal/bigasia/bigasia0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",БСТ"
        + "https://strm.yandex.ru/kal/bstufa/bstufa0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Ветта 24"
        + "https://strm.yandex.ru/kal/vetta24/vetta240_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Вся Уфа"
        + "https://strm.yandex.ru/kal/allufa/allufa0_54_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Грозный"
        + "https://strm.yandex.ru/kal/grozny_supres/grozny_supres0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Губерния"
        + "https://strm.yandex.ru/kal/guberniya_supres/guberniya_supres0_43_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",ДОН 24"
        + "https://strm.yandex.ru/kal/don24/don240_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Евроновости"
        + "https://strm.yandex.ru/kal/euronews_supres/euronews_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Жар Птица"
        + "https://strm.yandex.ru/kal/firebird/firebird0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Загородный"
        + "https://strm.yandex.ru/kal/zagorod/zagorod0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Катунь 24"
        + "https://strm.yandex.ru/kal/katun24_supres/katun24_supres0_1511_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Классика кино"
        + "https://strm.yandex.ru/kal/kinoclassic/kinoclassic0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Крик ТВ"
        + "https://strm.yandex.ru/kal/krik_tv/krik_tv0_43_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Кубань 24"
        + "https://strm.yandex.ru/kal/kuban24_supres/kuban24_supres0_54_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Липецкое время"
        + "https://strm.yandex.ru/kal/lipetcktime_supres/lipetcktime_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Любимое ТВ"
        + "https://strm.yandex.ru/kal/lovedtv/lovedtv0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Матур ТВ"
        + "https://strm.yandex.ru/kal/matur/matur0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",МИР24"
        + "https://strm.yandex.ru/kal/mir24_supres/mir24_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Москва 24"
        + "https://strm.yandex.ru/kal/msk24_supres/msk24_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Надежда"
        + "https://strm.yandex.ru/kal/nadejda_supres/nadejda_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Наша Сибирь"
        + "https://strm.yandex.ru/kal/sibir/sibir0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Неизвестная планета"
        + "https://strm.yandex.ru/kal/unknownplanet/unknownplanet0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Ноябрьск 24"
        + "https://strm.yandex.ru/kal/noyabrsk24/noyabrsk240_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",О2ТВ"
        + "https://strm.yandex.ru/kal/o2/o20_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",ОТВ 24"
        + "https://strm.yandex.ru/kal/otv24/otv240_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Продвижение"
        + "https://strm.yandex.ru/kal/prodvizheniye/prodvizheniye0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Радость моя"
        + "https://strm.yandex.ru/kal/radostmoya/radostmoya0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",РазТВ"
        + "https://strm.yandex.ru/kal/raztv_supres/raztv_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Ратник"
        + "https://strm.yandex.ru/kal/ratnik/ratnik0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Своё ТВ"
        + "https://strm.yandex.ru/kal/svoetv/svoetv0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",СОЮЗ"
        + "https://strm.yandex.ru/kal/soyuz_supres/soyuz_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Старт"
        + "https://strm.yandex.ru/kal/start/start0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",ТВ Центр Красноярск"
        + "https://strm.yandex.ru/kal/tck/tck0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",ТВТУР"
        + "https://strm.yandex.ru/kal/tvtour/tvtour0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Тномер"
        + "https://strm.yandex.ru/kal/tnomer/tnomer0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Точка ТВ"
        + "https://strm.yandex.ru/kal/tochkatv_cv_supres/tochkatv_cv_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Успех"
        + "https://strm.yandex.ru/kal/uspehtv_supres/uspehtv_supres0_1511_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Центральное телевидение"
        + "https://strm.yandex.ru/kal/ctv/ctv0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",ШАДР-инфо"
        + "https://strm.yandex.ru/kal/shadrinfo/shadrinfo0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Эхо ТВ"
        + "https://strm.yandex.ru/kal/echotv_supres/echotv_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",ACB TV"
        + "https://strm.yandex.ru/kal/acb/acb0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Deutsche Welle"
        + "https://strm.yandex.ru/kal/dw/dw0_169_576p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Fashion TV"
        + "https://strm.yandex.ru/kal/fashiontv/fashiontv0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Foodman.club"
        + "https://strm.yandex.ru/kal/foodmanclub/foodmanclub0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",France 24"
        + "https://strm.yandex.ru/kal/france24/france240_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",FreshTV"
        + "https://strm.yandex.ru/kal/fresh/fresh0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",HD Медиа"
        + "https://strm.yandex.ru/kal/hdmedia/hdmedia0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",HITV"
        + "https://strm.yandex.ru/kal/hittv/hittv0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Ocean TV"
        + "https://strm.yandex.ru/kal/oceantv_supres/oceantv_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",PRO Business"
        + "https://strm.yandex.ru/kal/probusiness_cv_supres/probusiness_cv_supres0_169_270p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",RT"
        + "https://strm.yandex.ru/kal/rt_hd/rt_hd0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",RT Doc"
        + "https://strm.yandex.ru/kal/rtd_hd/rtd_hd0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",RTG"
        + "https://strm.yandex.ru/kal/rtg/rtg0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",RTVI"
        + "https://strm.yandex.ru/kal/rtvi_supres/rtvi_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Russian Music Box"
        + "https://strm.yandex.ru/kal/rmbox/rmbox0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",TDK"
        + "https://strm.yandex.ru/kal/tdk_supres/tdk_supres0_43_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",TVMChannel"
        + "https://strm.yandex.ru/kal/tvm_supres/tvm_supres0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",World Fashion Channel"
        + "https://strm.yandex.ru/kal/fashion/fashion0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Дайвинг TV"
        + "https://strm.yandex.ru/kal/diving/diving0_169_720p.json/index-v1-a1.m3u8"
        + "\n#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"YaTV\",Красная Линия"
        + "https://strm.yandex.ru/kal/rline/rline0_169_576p.json/index-v1-a1.m3u8";
        public static string m3u2 = "#EXTM3U\n" +
                    "#EXTINF:-1 tvg-shift=\"2\" tvg-id=\"\" tvg-logo=\"\" group-title=\"All Channel\",Информация\n" +
                    "http://sosedi.hldns.ru/link/pay_please.mp4";
    }
}
/// <summary>
/// Использование textBox.SetWatermark("Same text");
/// </summary>
internal class WatermarkTextBox : TextBox
{
    private const uint ECM_FIRST = 0x1500;
    private const uint EM_SETCUEBANNER = ECM_FIRST + 1;
    private string watermarkText;
    public string WatermarkText
    {
        get { return watermarkText; }
        set
        {
            watermarkText = value;
            SetWatermark(watermarkText);
        }
    }
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)] private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
    private void SetWatermark(string watermarkText)
    {
        SendMessage(Handle, EM_SETCUEBANNER, 0, watermarkText);
    }
}