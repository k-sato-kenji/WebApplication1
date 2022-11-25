using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class salary
    {

        // ID
        public int id { get; set; }
        // 受給者
        [Display(Name = "受給者")]
        [Required(ErrorMessage = "受給者は必須入力です")]
        public string beneficiary { get; set; }
        // タイプ（給与、賞与）
        [Display(Name = "給与/賞与")]
        [Required(ErrorMessage = "給与/賞与は必須入力です")]
        public string paymenttype { get; set; }

        // 支給日
        [Display(Name = "支給日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //フォーマットの指定
        [DataType(DataType.Date)]                           //DataTypeの指定
        [Required(ErrorMessage = "支給日は必須入力です")]
        public DateTime paymentdate { get; set; }


        // 支給額
        [Display(Name = "支給額")]
        [Required(ErrorMessage = "支給額は必須入力です")]
        public decimal paymentamount { get; set; }
        // 交通費
        [Display(Name = "交通費")]
        public decimal travelexpence { get; set; }
        // 健康保険料
        [Display(Name = "健康保険料")]
        public decimal healthinsurancepremium { get; set; }
        // 厚生年金料
        [Display(Name = "厚生年金料")]
        public decimal welfarepension { get; set; }
        // 雇用保険料
        [Display(Name = "雇用保険料")]
        public decimal employmentinsurancepremium { get; set; }
        // 所得税
        [Display(Name = "所得税")]
        public decimal incometax { get; set; }
        // 住民税
        [Display(Name = "住民税")]
        public decimal residenttax { get; set; }
        // 総支給
        [Display(Name = "総支給額")]
        public decimal totalpaymentamount { get; set; }
        // 時間外手当
        [Display(Name = "時間外手当")]
        public decimal overtimeallowance { get; set; }
        // 深夜手当
        [Display(Name = "深夜手当")]
        public decimal midnightallowance { get; set; }
        // 休日手当
        [Display(Name = "休日手当")]
        public decimal holidayallowance { get; set; }
        // 備考
        [Display(Name = "備考")]
        public string remarks { get; set; }

    }
}
