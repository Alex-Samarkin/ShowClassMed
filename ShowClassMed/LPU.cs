using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowClassMed
{
    public class LPU : IEquatable<LPU>
    {
        [Category("Название")]
        [DisplayName("Краткое название")]
        [Description("")]
        public string ShortName { get; set; } = "Поликлиника";
        [Category("Название")]
        [DisplayName("Полное название")]
        [Description("")]
        public string FullName { get; set; } = "ГБУЗ Псковская городская поликлиника №";
        [Category("Адрес")]
        [DisplayName("Город")]
        [Description("")]
        public string City { get; set; } = "Псков";
        [Category("Адрес")]
        [DisplayName("Улица")]
        [Description("")]
        public string Street { get; set; } = "Народная";
        [Category("Адрес")]
        [DisplayName("Дом")]
        [Description("")]
        public string House { get; set; } = "18";
        [Category("Контакты")]
        [DisplayName("Телефон")]
        [Description("")]
        public string Phone { get; set; } = "+7 921 123 12 12";
        [Category("Контакты")]
        [DisplayName("Сайт")]
        [Description("")]
        public string Site { get; set; } = "https://yandex.ru";

        public override bool Equals(object obj)
        {
            return Equals(obj as LPU);
        }

        public bool Equals(LPU other)
        {
            return other != null &&
                   ShortName == other.ShortName &&
                   FullName == other.FullName &&
                   City == other.City &&
                   Street == other.Street &&
                   House == other.House &&
                   Phone == other.Phone &&
                   Site == other.Site;
        }

        public override int GetHashCode()
        {
            var hashCode = 1674458709;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ShortName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FullName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(House);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Site);
            return hashCode;
        }

        public static bool operator ==(LPU left, LPU right)
        {
            return EqualityComparer<LPU>.Default.Equals(left, right);
        }

        public static bool operator !=(LPU left, LPU right)
        {
            return !(left == right);
        }
    }
}
