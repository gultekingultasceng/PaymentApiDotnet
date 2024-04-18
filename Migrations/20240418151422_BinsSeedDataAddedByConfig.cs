using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApiDotnet.Migrations
{
    public partial class BinsSeedDataAddedByConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bins",
                columns: new[] { "Id", "BankCode", "BankName", "BinNumber", "CardSubType", "CardType", "Prepaid", "Virtual" },
                values: new object[,]
                {
                    { 1, 10, "T.C. ZİRAAT BANKASI A.Ş.", 413226, "PLATINUM", "VISA", "no", "no" },
                    { 2, 10, "T.C. ZİRAAT BANKASI A.Ş.", 444676, "CLASSIC", "VISA", "no", "no" },
                    { 3, 10, "T.C. ZİRAAT BANKASI A.Ş.", 444677, "GOLD", "VISA", "no", "no" },
                    { 4, 10, "T.C. ZİRAAT BANKASI A.Ş.", 444678, "PLATINUM", "VISA", "no", "no" },
                    { 5, 10, "T.C. ZİRAAT BANKASI A.Ş.", 453955, " CLASSIC", "VISA", "no", "no" },
                    { 6, 10, "T.C. ZİRAAT BANKASI A.Ş.", 453956, " GOLD", "VISA", "no", "no" },
                    { 7, 10, "T.C. ZİRAAT BANKASI A.Ş.", 454671, " CLASSIC", "VISA", "no", "no" },
                    { 8, 10, "T.C. ZİRAAT BANKASI A.Ş.", 454672, " CLASSIC", "VISA", "no", "no" },
                    { 9, 10, "T.C. ZİRAAT BANKASI A.Ş.", 454673, " BUSINESS", "VISA", "no", "no" },
                    { 10, 10, "T.C. ZİRAAT BANKASI A.Ş.", 454674, " GOLD", "VISA", "no", "no" },
                    { 11, 10, "T.C. ZİRAAT BANKASI A.Ş.", 454894, " CLASSIC", "VISA", "no", "no" },
                    { 12, 10, "T.C. ZİRAAT BANKASI A.Ş.", 540130, " CLASSIC", "MASTERCARD", "no", "no" },
                    { 13, 10, "T.C. ZİRAAT BANKASI A.Ş.", 540134, " GOLD", "MASTERCARD", "no", "no" },
                    { 14, 10, "T.C. ZİRAAT BANKASI A.Ş.", 541001, " CLASSIC", "MASTERCARD", "no", "no" },
                    { 15, 10, "T.C. ZİRAAT BANKASI A.Ş.", 541033, " GOLD", "MASTERCARD", "no", "no" },
                    { 16, 10, "T.C. ZİRAAT BANKASI A.Ş.", 542374, " CLASSIC", "MASTERCARD", "no", "no" },
                    { 17, 10, "T.C. ZİRAAT BANKASI A.Ş.", 547287, " BUSINESS", "MASTERCARD", "no", "no" },
                    { 18, 12, "T. HALK BANKASI A.Ş.", 415514, "PLATINUM", "VISA", "no", "no" },
                    { 19, 12, "T. HALK BANKASI A.Ş.", 492094, "GOLD", "VISA", "no", "no" },
                    { 20, 12, "T. HALK BANKASI A.Ş.", 492095, "CLASSIC", "VISA", "no", "no" },
                    { 21, 12, "T. HALK BANKASI A.Ş.", 498852, "BUSINESS", "VISA", "no", "no" },
                    { 22, 12, "T. HALK BANKASI A.Ş.", 521378, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 23, 12, "T. HALK BANKASI A.Ş.", 540435, "GOLD", "MASTERCARD", "no", "no" },
                    { 24, 12, "T. HALK BANKASI A.Ş.", 543081, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 25, 12, "T. HALK BANKASI A.Ş.", 552879, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 26, 12, "T. HALK BANKASI A.Ş.", 510056, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 27, 15, "T. VAKIFLAR BANKASI T.A.O.", 402940, "CLASSIC", "VISA", "no", "no" },
                    { 28, 15, "T. VAKIFLAR BANKASI T.A.O.", 409084, "CLASSIC", "VISA", "no", "no" },
                    { 29, 15, "T. VAKIFLAR BANKASI T.A.O.", 411724, "CLASSIC", "VISA", "no", "no" },
                    { 30, 15, "T. VAKIFLAR BANKASI T.A.O.", 411942, "CLASSIC", "VISA", "no", "no" },
                    { 31, 15, "T. VAKIFLAR BANKASI T.A.O.", 411943, "CLASSIC", "VISA", "no", "no" },
                    { 32, 15, "T. VAKIFLAR BANKASI T.A.O.", 411944, "CLASSIC", "VISA", "no", "no" },
                    { 33, 15, "T. VAKIFLAR BANKASI T.A.O.", 411979, "PLATINUM", "VISA", "no", "no" },
                    { 34, 15, "T. VAKIFLAR BANKASI T.A.O.", 415792, "CLASSIC", "VISA", "no", "no" },
                    { 35, 15, "T. VAKIFLAR BANKASI T.A.O.", 416757, "CLASSIC", "VISA", "no", "no" },
                    { 36, 15, "T. VAKIFLAR BANKASI T.A.O.", 428945, "BUSINESS", "VISA", "no", "no" },
                    { 37, 15, "T. VAKIFLAR BANKASI T.A.O.", 493840, "CLASSIC", "VISA", "no", "no" },
                    { 38, 15, "T. VAKIFLAR BANKASI T.A.O.", 493841, "CLASSIC", "VISA", "no", "no" },
                    { 39, 15, "T. VAKIFLAR BANKASI T.A.O.", 493846, "GOLD", "VISA", "no", "no" },
                    { 40, 15, "T. VAKIFLAR BANKASI T.A.O.", 520017, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 41, 15, "T. VAKIFLAR BANKASI T.A.O.", 540045, "GOLD", "MASTERCARD", "no", "no" },
                    { 42, 15, "T. VAKIFLAR BANKASI T.A.O.", 540046, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 43, 15, "T. VAKIFLAR BANKASI T.A.O.", 542119, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 44, 15, "T. VAKIFLAR BANKASI T.A.O.", 542798, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 45, 15, "T. VAKIFLAR BANKASI T.A.O.", 542804, "GOLD", "MASTERCARD", "no", "no" },
                    { 46, 15, "T. VAKIFLAR BANKASI T.A.O.", 547244, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 47, 15, "T. VAKIFLAR BANKASI T.A.O.", 552101, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 48, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 402458, "CLASSIC", "VISA", "no", "no" },
                    { 49, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 402459, "CLASSIC", "VISA", "no", "no" },
                    { 50, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 406015, "GOLD", "VISA", "no", "no" },
                    { 51, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 427707, "BUSINESS", "VISA", "no", "no" },
                    { 52, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 440247, "CLASSIC", "VISA", "no", "no" },
                    { 53, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 440273, "GOLD", "VISA", "no", "no" },
                    { 54, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 440293, "CLASSIC", "VISA", "no", "no" },
                    { 55, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 440294, "GOLD", "VISA", "no", "no" },
                    { 56, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 479227, "BUSINESS", "VISA", "no", "no" },
                    { 57, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 489494, "CLASSIC", "VISA", "no", "no" },
                    { 58, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 489495, "PLATINUM", "VISA", "no", "no" },
                    { 59, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 489496, "BUSINESS", "VISA", "no", "no" },
                    { 60, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 510138, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 61, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 510139, "GOLD", "MASTERCARD", "no", "no" },
                    { 62, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 510221, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 63, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 512753, "GOLD", "MASTERCARD", "no", "no" },
                    { 64, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 512803, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 65, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 524346, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 66, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 524839, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 67, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 524840, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 68, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 528920, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 69, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 530853, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 70, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 545124, "SIGNIA", "MASTERCARD", "no", "no" },
                    { 71, 32, "TÜRK EKONOMİ BANKASI A.Ş.", 553090, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 72, 46, "AKBANK T.A.Ş.", 413252, "PLATINUM", "VISA", "no", "no" },
                    { 73, 46, "AKBANK T.A.Ş.", 425669, "BUSINESS", "VISA", "no", "no" },
                    { 74, 46, "AKBANK T.A.Ş.", 432071, "GOLD", "VISA", "no", "no" },
                    { 75, 46, "AKBANK T.A.Ş.", 432072, "PLATINUM", "VISA", "no", "no" },
                    { 76, 46, "AKBANK T.A.Ş.", 435508, "CLASSIC", "VISA", "no", "no" },
                    { 77, 46, "AKBANK T.A.Ş.", 435509, "GOLD", "VISA", "no", "no" },
                    { 78, 46, "AKBANK T.A.Ş.", 493837, "Acquiring", "VISA", "no", "no" },
                    { 79, 46, "AKBANK T.A.Ş.", 512754, "GOLD", "MASTERCARD", "no", "no" },
                    { 80, 46, "AKBANK T.A.Ş.", 520932, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 81, 46, "AKBANK T.A.Ş.", 521807, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 82, 46, "AKBANK T.A.Ş.", 524347, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 83, 46, "AKBANK T.A.Ş.", 542110, "Acquiring", "MASTERCARD", "no", "no" },
                    { 84, 46, "AKBANK T.A.Ş.", 552608, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 85, 46, "AKBANK T.A.Ş.", 552609, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 86, 46, "AKBANK T.A.Ş.", 553056, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 87, 46, "AKBANK T.A.Ş.", 557113, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 88, 46, "AKBANK T.A.Ş.", 557829, "GOLD", "MASTERCARD", "no", "no" },
                    { 89, 59, "ŞEKERBANK T.A.Ş.", 403836, "BUSINESS", "VISA", "no", "no" },
                    { 90, 59, "ŞEKERBANK T.A.Ş.", 409622, "Acquiring", "VISA", "no", "no" },
                    { 91, 59, "ŞEKERBANK T.A.Ş.", 411156, "CLASSIC", "VISA", "no", "no" },
                    { 92, 59, "ŞEKERBANK T.A.Ş.", 411157, "GOLD", "VISA", "no", "no" },
                    { 93, 59, "ŞEKERBANK T.A.Ş.", 411158, "PLATINUM", "VISA", "no", "no" },
                    { 94, 59, "ŞEKERBANK T.A.Ş.", 411159, "BUSINESS", "VISA", "no", "no" },
                    { 95, 59, "ŞEKERBANK T.A.Ş.", 411160, "Acquiring", "VISA", "no", "no" },
                    { 96, 59, "ŞEKERBANK T.A.Ş.", 433383, "CLASSIC", "VISA", "no", "no" },
                    { 97, 59, "ŞEKERBANK T.A.Ş.", 433384, "GOLD", "VISA", "no", "no" },
                    { 98, 59, "ŞEKERBANK T.A.Ş.", 494063, "GOLD", "VISA", "no", "no" },
                    { 99, 59, "ŞEKERBANK T.A.Ş.", 494064, "CLASSIC", "VISA", "no", "no" },
                    { 100, 59, "ŞEKERBANK T.A.Ş.", 521394, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 101, 59, "ŞEKERBANK T.A.Ş.", 521827, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 102, 59, "ŞEKERBANK T.A.Ş.", 525404, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 103, 59, "ŞEKERBANK T.A.Ş.", 530866, "GOLD", "MASTERCARD", "no", "no" },
                    { 104, 59, "ŞEKERBANK T.A.Ş.", 539703, "GOLD", "MASTERCARD", "no", "no" },
                    { 105, 59, "ŞEKERBANK T.A.Ş.", 547311, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 106, 59, "ŞEKERBANK T.A.Ş.", 549208, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 107, 59, "ŞEKERBANK T.A.Ş.", 549394, "Acquiring", "MASTERCARD", "no", "no" },
                    { 108, 62, "T. GARANTİ BANKASI A.Ş.", 403280, "CLASSIC", "VISA", "no", "no" },
                    { 109, 62, "T. GARANTİ BANKASI A.Ş.", 403666, "BUSINESS", "VISA", "no", "no" },
                    { 110, 62, "T. GARANTİ BANKASI A.Ş.", 404308, "CLASSIC", "VISA", "no", "no" },
                    { 111, 62, "T. GARANTİ BANKASI A.Ş.", 413836, "PLATINUM", "VISA", "no", "no" },
                    { 112, 62, "T. GARANTİ BANKASI A.Ş.", 426886, "CLASSIC", "VISA", "no", "no" },
                    { 113, 62, "T. GARANTİ BANKASI A.Ş.", 426887, "GOLD", "VISA", "no", "no" },
                    { 114, 62, "T. GARANTİ BANKASI A.Ş.", 426888, "PLATINUM", "VISA", "no", "no" },
                    { 115, 62, "T. GARANTİ BANKASI A.Ş.", 427314, "BUSINESS", "VISA", "no", "no" },
                    { 116, 62, "T. GARANTİ BANKASI A.Ş.", 427315, "BUSINESS", "VISA", "no", "no" },
                    { 117, 62, "T. GARANTİ BANKASI A.Ş.", 428220, "CLASSIC", "VISA", "no", "no" },
                    { 118, 62, "T. GARANTİ BANKASI A.Ş.", 428221, "PLATINUM", "VISA", "no", "no" },
                    { 119, 62, "T. GARANTİ BANKASI A.Ş.", 432154, "CLASSIC", "VISA", "no", "no" },
                    { 120, 62, "T. GARANTİ BANKASI A.Ş.", 448472, "BUSINESS", "VISA", "no", "no" },
                    { 121, 62, "T. GARANTİ BANKASI A.Ş.", 461668, "PLATINUM", "VISA", "no", "no" },
                    { 122, 62, "T. GARANTİ BANKASI A.Ş.", 462274, "BUSINESS", "VISA", "no", "no" },
                    { 123, 62, "T. GARANTİ BANKASI A.Ş.", 467293, "GOLD", "VISA", "no", "no" },
                    { 124, 62, "T. GARANTİ BANKASI A.Ş.", 467294, "CLASSIC", "VISA", "no", "no" },
                    { 125, 62, "T. GARANTİ BANKASI A.Ş.", 467295, "BUSINESS", "VISA", "no", "no" },
                    { 126, 62, "T. GARANTİ BANKASI A.Ş.", 474151, "CLASSIC", "VISA", "no", "no" },
                    { 127, 62, "T. GARANTİ BANKASI A.Ş.", 482489, "CLASSIC", "VISA", "no", "no" },
                    { 128, 62, "T. GARANTİ BANKASI A.Ş.", 482490, "GOLD", "VISA", "no", "no" },
                    { 129, 62, "T. GARANTİ BANKASI A.Ş.", 482491, "PLATINUM", "VISA", "no", "no" },
                    { 130, 62, "T. GARANTİ BANKASI A.Ş.", 486567, "BUSINESS", "VISA", "no", "no" },
                    { 131, 62, "T. GARANTİ BANKASI A.Ş.", 487074, "CLASSIC", "VISA", "no", "no" },
                    { 132, 62, "T. GARANTİ BANKASI A.Ş.", 487075, "CLASSIC", "VISA", "no", "no" },
                    { 133, 62, "T. GARANTİ BANKASI A.Ş.", 489478, "GOLD", "VISA", "no", "no" },
                    { 134, 62, "T. GARANTİ BANKASI A.Ş.", 490175, "CLASSIC", "VISA", "no", "no" },
                    { 135, 62, "T. GARANTİ BANKASI A.Ş.", 492186, "CLASSIC", "VISA", "no", "no" },
                    { 136, 62, "T. GARANTİ BANKASI A.Ş.", 492187, "GOLD", "VISA", "no", "no" },
                    { 137, 62, "T. GARANTİ BANKASI A.Ş.", 492193, "CLASSIC", "VISA", "no", "no" },
                    { 138, 62, "T. GARANTİ BANKASI A.Ş.", 493845, "GOLD", "VISA", "no", "no" },
                    { 139, 62, "T. GARANTİ BANKASI A.Ş.", 514915, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 140, 62, "T. GARANTİ BANKASI A.Ş.", 520097, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 141, 62, "T. GARANTİ BANKASI A.Ş.", 520922, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 142, 62, "T. GARANTİ BANKASI A.Ş.", 520940, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 143, 62, "T. GARANTİ BANKASI A.Ş.", 520988, "GOLD", "MASTERCARD", "no", "no" },
                    { 144, 62, "T. GARANTİ BANKASI A.Ş.", 521368, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 145, 62, "T. GARANTİ BANKASI A.Ş.", 521824, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 146, 62, "T. GARANTİ BANKASI A.Ş.", 521825, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 147, 62, "T. GARANTİ BANKASI A.Ş.", 521832, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 148, 62, "T. GARANTİ BANKASI A.Ş.", 522204, "GOLD", "MASTERCARD", "no", "no" },
                    { 149, 62, "T. GARANTİ BANKASI A.Ş.", 528939, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 150, 62, "T. GARANTİ BANKASI A.Ş.", 528956, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 151, 62, "T. GARANTİ BANKASI A.Ş.", 533169, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 152, 62, "T. GARANTİ BANKASI A.Ş.", 534261, "WORLD", "MASTERCARD", "no", "no" },
                    { 153, 62, "T. GARANTİ BANKASI A.Ş.", 540036, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 154, 62, "T. GARANTİ BANKASI A.Ş.", 540037, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 155, 62, "T. GARANTİ BANKASI A.Ş.", 540226, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 156, 62, "T. GARANTİ BANKASI A.Ş.", 540227, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 157, 62, "T. GARANTİ BANKASI A.Ş.", 540669, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 158, 62, "T. GARANTİ BANKASI A.Ş.", 540709, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 159, 62, "T. GARANTİ BANKASI A.Ş.", 541865, "GOLD", "MASTERCARD", "no", "no" },
                    { 160, 62, "T. GARANTİ BANKASI A.Ş.", 542030, "GOLD", "MASTERCARD", "no", "no" },
                    { 161, 62, "T. GARANTİ BANKASI A.Ş.", 544078, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 162, 62, "T. GARANTİ BANKASI A.Ş.", 545102, "SIGNIA", "MASTERCARD", "no", "no" },
                    { 163, 62, "T. GARANTİ BANKASI A.Ş.", 546001, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 164, 62, "T. GARANTİ BANKASI A.Ş.", 547302, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 165, 62, "T. GARANTİ BANKASI A.Ş.", 552095, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 166, 62, "T. GARANTİ BANKASI A.Ş.", 553130, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 167, 62, "T. GARANTİ BANKASI A.Ş.", 554796, "GOLD", "MASTERCARD", "no", "no" },
                    { 168, 62, "T. GARANTİ BANKASI A.Ş.", 554960, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 169, 62, "T. GARANTİ BANKASI A.Ş.", 557023, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 170, 62, "T. GARANTİ BANKASI A.Ş.", 557945, "CLASSIC ", "MASTERCARD", "no", "no" },
                    { 171, 62, "T. GARANTİ BANKASI A.Ş.", 558699, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 172, 64, "T. İŞ BANKASI A.Ş.", 418342, "CLASSIC", "VISA", "no", "no" },
                    { 173, 64, "T. İŞ BANKASI A.Ş.", 418343, "CLASSIC", "VISA", "no", "no" },
                    { 174, 64, "T. İŞ BANKASI A.Ş.", 418344, "GOLD", "VISA", "no", "no" },
                    { 175, 64, "T. İŞ BANKASI A.Ş.", 418345, "GOLD", "VISA", "no", "no" },
                    { 176, 64, "T. İŞ BANKASI A.Ş.", 450803, "BUSINESS", "VISA", "no", "no" },
                    { 177, 64, "T. İŞ BANKASI A.Ş.", 454318, "CLASSIC", "VISA", "no", "no" },
                    { 178, 64, "T. İŞ BANKASI A.Ş.", 454358, "GOLD", "VISA", "no", "no" },
                    { 179, 64, "T. İŞ BANKASI A.Ş.", 454359, "GOLD", "VISA", "no", "no" },
                    { 180, 64, "T. İŞ BANKASI A.Ş.", 454360, "CLASSIC", "VISA", "no", "no" },
                    { 181, 64, "T. İŞ BANKASI A.Ş.", 510152, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 182, 64, "T. İŞ BANKASI A.Ş.", 540667, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 183, 64, "T. İŞ BANKASI A.Ş.", 540668, "GOLD", "MASTERCARD", "no", "no" },
                    { 184, 64, "T. İŞ BANKASI A.Ş.", 543771, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 185, 64, "T. İŞ BANKASI A.Ş.", 552096, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 186, 64, "T. İŞ BANKASI A.Ş.", 553058, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 187, 67, "YAPI ve KREDİ BANKASI A.Ş.", 404809, "CLASSIC", "VISA", "no", "no" },
                    { 188, 67, "YAPI ve KREDİ BANKASI A.Ş.", 446212, "CLASSIC", "VISA", "no", "no" },
                    { 189, 67, "YAPI ve KREDİ BANKASI A.Ş.", 450634, "CLASSIC", "VISA", "no", "no" },
                    { 190, 67, "YAPI ve KREDİ BANKASI A.Ş.", 455359, "BUSINESS", "VISA", "no", "no" },
                    { 191, 67, "YAPI ve KREDİ BANKASI A.Ş.", 477959, "Acquiring", "VISA", "no", "no" },
                    { 192, 67, "YAPI ve KREDİ BANKASI A.Ş.", 479794, "CLASSIC", "VISA", "no", "no" },
                    { 193, 67, "YAPI ve KREDİ BANKASI A.Ş.", 479795, "GOLD", "VISA", "no", "no" },
                    { 194, 67, "YAPI ve KREDİ BANKASI A.Ş.", 491205, "CLASSIC", "VISA", "no", "no" },
                    { 195, 67, "YAPI ve KREDİ BANKASI A.Ş.", 491206, "PLATINUM", "VISA", "no", "no" },
                    { 196, 67, "YAPI ve KREDİ BANKASI A.Ş.", 492128, "CLASSIC", "VISA", "no", "no" },
                    { 197, 67, "YAPI ve KREDİ BANKASI A.Ş.", 492130, "GOLD", "VISA", "no", "no" },
                    { 198, 67, "YAPI ve KREDİ BANKASI A.Ş.", 492131, "GOLD", "VISA", "no", "no" },
                    { 199, 67, "YAPI ve KREDİ BANKASI A.Ş.", 510054, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 200, 67, "YAPI ve KREDİ BANKASI A.Ş.", 540061, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 201, 67, "YAPI ve KREDİ BANKASI A.Ş.", 540062, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 202, 67, "YAPI ve KREDİ BANKASI A.Ş.", 540063, "GOLD", "MASTERCARD", "no", "no" },
                    { 203, 67, "YAPI ve KREDİ BANKASI A.Ş.", 540122, " CLASSIC", "MASTERCARD", "no", "no" },
                    { 204, 67, "YAPI ve KREDİ BANKASI A.Ş.", 540129, " GOLD", "MASTERCARD", "no", "no" },
                    { 205, 67, "YAPI ve KREDİ BANKASI A.Ş.", 542117, " CLASSIC", "MASTERCARD", "no", "no" },
                    { 206, 67, "YAPI ve KREDİ BANKASI A.Ş.", 545103, " SIGNIA", "MASTERCARD", "no", "no" },
                    { 207, 67, "YAPI ve KREDİ BANKASI A.Ş.", 552645, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 208, 67, "YAPI ve KREDİ BANKASI A.Ş.", 552659, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 209, 67, "YAPI ve KREDİ BANKASI A.Ş.", 554422, "Acquiring", "MASTERCARD", "no", "no" },
                    { 210, 71, "FORTIS BANK A.Ş.", 427308, " BUSINESS", "VISA", "no", "no" },
                    { 211, 71, "FORTIS BANK A.Ş.", 438040, "PLATINUM", "VISA", "no", "no" },
                    { 212, 71, "FORTIS BANK A.Ş.", 450918, " CLASSIC", "VISA", "no", "no" },
                    { 213, 71, "FORTIS BANK A.Ş.", 455645, " GOLD", "VISA", "no", "no" },
                    { 214, 71, "FORTIS BANK A.Ş.", 525314, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 215, 71, "FORTIS BANK A.Ş.", 542259, "TITANIUM", "MASTERCARD", "no", "no" },
                    { 216, 71, "FORTIS BANK A.Ş.", 547985, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 217, 71, "FORTIS BANK A.Ş.", 545148, "SIGNIA", "MASTERCARD", "no", "no" },
                    { 218, 71, "FORTIS BANK A.Ş.", 549998, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 219, 71, "FORTIS BANK A.Ş.", 550449, "GOLD", "MASTERCARD", "no", "no" },
                    { 220, 71, "FORTIS BANK A.Ş.", 552207, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 221, 92, "CITIBANK A.Ş.", 426391, "GOLD", "VISA", "no", "no" },
                    { 222, 92, "CITIBANK A.Ş.", 426392, "CLASSIC", "VISA", "no", "no" },
                    { 223, 92, "CITIBANK A.Ş.", 450050, "CLASSIC", "VISA", "no", "no" },
                    { 224, 92, "CITIBANK A.Ş.", 450051, "GOLD", "VISA", "no", "no" },
                    { 225, 92, "CITIBANK A.Ş.", 521376, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 226, 92, "CITIBANK A.Ş.", 544127, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 227, 92, "CITIBANK A.Ş.", 544445, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 228, 92, "CITIBANK A.Ş.", 544460, "GOLD", "MASTERCARD", "no", "no" },
                    { 229, 92, "CITIBANK A.Ş.", 547712, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 230, 92, "CITIBANK A.Ş.", 549220, "GOLD", "MASTERCARD", "no", "no" },
                    { 231, 96, "TURKISH BANK A.Ş.", 419389, "Acquiring", "VISA", "no", "no" },
                    { 232, 96, "TURKISH BANK A.Ş.", 518599, "GOLD", "MASTERCARD", "no", "no" },
                    { 233, 96, "TURKISH BANK A.Ş.", 529939, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 234, 96, "TURKISH BANK A.Ş.", 552098, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 235, 99, "ING BANK A.Ş.", 400684, "CLASSIC", "VISA", "no", "no" },
                    { 236, 99, "ING BANK A.Ş.", 408579, "CLASSIC", "VISA", "no", "no" },
                    { 237, 99, "ING BANK A.Ş.", 414070, "PLATINUM", "VISA", "no", "no" },
                    { 238, 99, "ING BANK A.Ş.", 420322, "GOLD", "VISA", "no", "no" },
                    { 239, 99, "ING BANK A.Ş.", 420323, "GOLD", "VISA", "no", "no" },
                    { 240, 99, "ING BANK A.Ş.", 420324, "PLATINUM", "VISA", "no", "no" },
                    { 241, 99, "ING BANK A.Ş.", 455571, "GOLD", "VISA", "no", "no" },
                    { 242, 99, "ING BANK A.Ş.", 480296, "BUSINESS", "VISA", "no", "no" },
                    { 243, 99, "ING BANK A.Ş.", 490805, "CLASSIC", "VISA", "no", "no" },
                    { 244, 99, "ING BANK A.Ş.", 490806, "GOLD", "VISA", "no", "no" },
                    { 245, 99, "ING BANK A.Ş.", 490807, "BUSINESS", "VISA", "no", "no" },
                    { 246, 99, "ING BANK A.Ş.", 510151, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 247, 99, "ING BANK A.Ş.", 532443, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 248, 99, "ING BANK A.Ş.", 540024, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 249, 99, "ING BANK A.Ş.", 540025, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 250, 99, "ING BANK A.Ş.", 542029, "GOLD", "MASTERCARD", "no", "no" },
                    { 251, 99, "ING BANK A.Ş.", 542605, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 252, 99, "ING BANK A.Ş.", 542965, "GOLD", "MASTERCARD", "no", "no" },
                    { 253, 99, "ING BANK A.Ş.", 542967, "GOLD", "MASTERCARD", "no", "no" },
                    { 254, 99, "ING BANK A.Ş.", 547765, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 255, 99, "ING BANK A.Ş.", 548819, "GOLD", "MASTERCARD", "no", "no" },
                    { 256, 99, "ING BANK A.Ş.", 554297, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 257, 99, "ING BANK A.Ş.", 554570, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 258, 103, "MILLENNIUM BANK A.Ş.", 518679, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 259, 103, "MILLENNIUM BANK A.Ş.", 534913, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 260, 103, "MILLENNIUM BANK A.Ş.", 543624, "GOLD", "MASTERCARD", "no", "no" },
                    { 261, 108, "TURKLAND BANK A.Ş.", 548375, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 262, 111, "FİNANS BANK A.Ş.", 402277, "CLASSIC", "VISA", "no", "no" },
                    { 263, 111, "FİNANS BANK A.Ş.", 402278, "GOLD", "VISA", "no", "no" },
                    { 264, 111, "FİNANS BANK A.Ş.", 402563, "CLASSIC", "VISA", "no", "no" },
                    { 265, 111, "FİNANS BANK A.Ş.", 403082, "BUSINESS", "VISA", "no", "no" },
                    { 266, 111, "FİNANS BANK A.Ş.", 409364, "CLASSIC", "VISA", "no", "no" },
                    { 267, 111, "FİNANS BANK A.Ş.", 410147, "CLASSIC", "VISA", "no", "no" },
                    { 268, 111, "FİNANS BANK A.Ş.", 413583, "GOLD", "VISA", "no", "no" },
                    { 269, 111, "FİNANS BANK A.Ş.", 414388, "CLASSIC", "VISA", "no", "no" },
                    { 270, 111, "FİNANS BANK A.Ş.", 415565, "CLASSIC", "VISA", "no", "no" },
                    { 271, 111, "FİNANS BANK A.Ş.", 422376, "CLASSIC", "VISA", "no", "no" },
                    { 272, 111, "FİNANS BANK A.Ş.", 423277, "CLASSIC", "VISA", "no", "no" },
                    { 273, 111, "FİNANS BANK A.Ş.", 423398, "CLASSIC", "VISA", "no", "no" },
                    { 274, 111, "FİNANS BANK A.Ş.", 427311, "BUSINESS", "VISA", "no", "no" },
                    { 275, 111, "FİNANS BANK A.Ş.", 435653, "PLATINUM", "VISA", "no", "no" },
                    { 276, 111, "FİNANS BANK A.Ş.", 441007, "CLASSIC", "VISA", "no", "no" },
                    { 277, 111, "FİNANS BANK A.Ş.", 444029, "GOLD", "VISA", "no", "no" },
                    { 278, 111, "FİNANS BANK A.Ş.", 499850, "CLASSIC", "VISA", "no", "no" },
                    { 279, 111, "FİNANS BANK A.Ş.", 499851, "PLATINUM", "VISA", "no", "no" },
                    { 280, 111, "FİNANS BANK A.Ş.", 499852, "CLASSIC", "VISA", "no", "no" },
                    { 281, 111, "FİNANS BANK A.Ş.", 519324, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 282, 111, "FİNANS BANK A.Ş.", 521022, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 283, 111, "FİNANS BANK A.Ş.", 521836, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 284, 111, "FİNANS BANK A.Ş.", 529572, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 285, 111, "FİNANS BANK A.Ş.", 531157, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 286, 111, "FİNANS BANK A.Ş.", 545120, "SIGNIA", "MASTERCARD", "no", "no" },
                    { 287, 111, "FİNANS BANK A.Ş.", 545616, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 288, 111, "FİNANS BANK A.Ş.", 545847, "GOLD", "MASTERCARD", "no", "no" },
                    { 289, 111, "FİNANS BANK A.Ş.", 547567, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 290, 111, "FİNANS BANK A.Ş.", 547800, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 291, 123, "HSBC BANK A.Ş.", 405913, "GOLD", "VISA", "no", "no" },
                    { 292, 123, "HSBC BANK A.Ş.", 405917, "CLASSIC", "VISA", "no", "no" },
                    { 293, 123, "HSBC BANK A.Ş.", 405918, "GOLD", "VISA", "no", "no" },
                    { 294, 123, "HSBC BANK A.Ş.", 409071, "CLASSIC", "VISA", "no", "no" },
                    { 295, 123, "HSBC BANK A.Ş.", 422629, "GOLD", "VISA", "no", "no" },
                    { 296, 123, "HSBC BANK A.Ş.", 424909, "CLASSIC", "VISA", "no", "no" },
                    { 297, 123, "HSBC BANK A.Ş.", 428240, "PLATINUM", "VISA", "no", "no" },
                    { 298, 123, "HSBC BANK A.Ş.", 496019, "CLASSIC", "VISA", "no", "no" },
                    { 299, 123, "HSBC BANK A.Ş.", 510005, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 300, 123, "HSBC BANK A.Ş.", 512651, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 301, 123, "HSBC BANK A.Ş.", 519399, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 302, 123, "HSBC BANK A.Ş.", 521045, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 303, 123, "HSBC BANK A.Ş.", 522054, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 304, 123, "HSBC BANK A.Ş.", 525413, "GOLD", "MASTERCARD", "no", "no" },
                    { 305, 123, "HSBC BANK A.Ş.", 525795, "GOLD", "MASTERCARD", "no", "no" },
                    { 306, 123, "HSBC BANK A.Ş.", 540643, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 307, 123, "HSBC BANK A.Ş.", 542254, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 308, 123, "HSBC BANK A.Ş.", 545183, "SIGNIA", "MASTERCARD", "no", "no" },
                    { 309, 123, "HSBC BANK A.Ş.", 550472, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 310, 123, "HSBC BANK A.Ş.", 550473, "GOLD", "MASTERCARD", "no", "no" },
                    { 311, 123, "HSBC BANK A.Ş.", 552143, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 312, 123, "HSBC BANK A.Ş.", 556030, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 313, 123, "HSBC BANK A.Ş.", 556031, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 314, 123, "HSBC BANK A.Ş.", 556033, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 315, 123, "HSBC BANK A.Ş.", 556034, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 316, 123, "HSBC BANK A.Ş.", 556665, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 317, 125, "EUROBANK TEKFEN A.Ş.", 424407, "BUSINESS", "VISA", "no", "no" },
                    { 318, 125, "EUROBANK TEKFEN A.Ş.", 483013, "Acquiring", "VISA", "no", "no" },
                    { 319, 125, "EUROBANK TEKFEN A.Ş.", 491373, "GOLD", "VISA", "no", "no" },
                    { 320, 125, "EUROBANK TEKFEN A.Ş.", 491374, "CLASSIC", "VISA", "no", "no" },
                    { 321, 125, "EUROBANK TEKFEN A.Ş.", 498516, "CLASSIC", "VISA", "no", "no" },
                    { 322, 125, "EUROBANK TEKFEN A.Ş.", 498517, "GOLD", "VISA", "no", "no" },
                    { 323, 125, "EUROBANK TEKFEN A.Ş.", 498518, "PLATINUM", "VISA", "no", "no" },
                    { 324, 125, "EUROBANK TEKFEN A.Ş.", 498519, "PLATINUM", "VISA", "no", "no" },
                    { 325, 125, "EUROBANK TEKFEN A.Ş.", 498520, "BUSINESS", "VISA", "no", "no" },
                    { 326, 125, "EUROBANK TEKFEN A.Ş.", 498521, "BUSINESS", "VISA", "no", "no" },
                    { 327, 125, "EUROBANK TEKFEN A.Ş.", 543943, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 328, 125, "EUROBANK TEKFEN A.Ş.", 543944, "GOLD", "MASTERCARD", "no", "no" },
                    { 329, 125, "EUROBANK TEKFEN A.Ş.", 545863, "Acquiring", "MASTERCARD", "no", "no" },
                    { 330, 125, "EUROBANK TEKFEN A.Ş.", 547680, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 331, 134, "DENİZBANK A.Ş.", 403134, "BUSINESS", "VISA", "no", "no" },
                    { 332, 134, "DENİZBANK A.Ş.", 408625, "PLATINUM", "VISA", "no", "no" },
                    { 333, 134, "DENİZBANK A.Ş.", 409070, "CLASSIC", "VISA", "no", "no" },
                    { 334, 134, "DENİZBANK A.Ş.", 411924, "BUSINESS", "VISA", "no", "no" },
                    { 335, 134, "DENİZBANK A.Ş.", 423667, "CLASSIC", "VISA", "no", "no" },
                    { 336, 134, "DENİZBANK A.Ş.", 424360, "CLASSIC", "VISA", "no", "no" },
                    { 337, 134, "DENİZBANK A.Ş.", 424361, "CLASSIC", "VISA", "no", "no" },
                    { 338, 134, "DENİZBANK A.Ş.", 441139, "CLASSIC", "VISA", "no", "no" },
                    { 339, 134, "DENİZBANK A.Ş.", 460345, "CLASSIC", "VISA", "no", "no" },
                    { 340, 134, "DENİZBANK A.Ş.", 460347, "GOLD", "VISA", "no", "no" },
                    { 341, 134, "DENİZBANK A.Ş.", 462276, "CLASSIC", "VISA", "no", "no" },
                    { 342, 134, "DENİZBANK A.Ş.", 472914, "BUSINESS", "VISA", "no", "no" },
                    { 343, 134, "DENİZBANK A.Ş.", 489456, "CLASSIC", "VISA", "no", "no" },
                    { 344, 134, "DENİZBANK A.Ş.", 510063, "GOLD", "MASTERCARD", "no", "no" },
                    { 345, 134, "DENİZBANK A.Ş.", 510118, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 346, 134, "DENİZBANK A.Ş.", 510119, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 347, 134, "DENİZBANK A.Ş.", 512017, "GOLD", "MASTERCARD", "no", "no" },
                    { 348, 134, "DENİZBANK A.Ş.", 512117, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 349, 134, "DENİZBANK A.Ş.", 514924, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 350, 134, "DENİZBANK A.Ş.", 520019, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 351, 134, "DENİZBANK A.Ş.", 520303, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 352, 134, "DENİZBANK A.Ş.", 543358, " CLASSIC", "MASTERCARD", "no", "no" },
                    { 353, 134, "DENİZBANK A.Ş.", 543400, "GOLD", "MASTERCARD", "no", "no" },
                    { 354, 134, "DENİZBANK A.Ş.", 543427, " CLASSIC", "MASTERCARD", "no", "no" },
                    { 355, 134, "DENİZBANK A.Ş.", 546764, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 356, 134, "DENİZBANK A.Ş.", 554483, "GOLD", "MASTERCARD", "no", "no" },
                    { 357, 134, "DENİZBANK A.Ş.", 558514, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 358, 135, "ANADOLUBANK A.Ş.", 425846, "GOLD", "VISA", "no", "no" },
                    { 359, 135, "ANADOLUBANK A.Ş.", 425847, "CLASSIC", "VISA", "no", "no" },
                    { 360, 135, "ANADOLUBANK A.Ş.", 425848, "BUSINESS", "VISA", "no", "no" },
                    { 361, 135, "ANADOLUBANK A.Ş.", 441341, "PLATINUM", "VISA", "no", "no" },
                    { 362, 135, "ANADOLUBANK A.Ş.", 522240, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 363, 135, "ANADOLUBANK A.Ş.", 522241, "GOLD", "MASTERCARD", "no", "no" },
                    { 364, 135, "ANADOLUBANK A.Ş.", 554301, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 365, 135, "ANADOLUBANK A.Ş.", 558593, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 366, 203, "ALBARAKA TÜRK KATILIM BANKASI A.Ş.", 417715, "BUSINESS", "VISA", "no", "no" },
                    { 367, 203, "ALBARAKA TÜRK KATILIM BANKASI A.Ş.", 432284, "CLASSIC", "VISA", "no", "no" },
                    { 368, 203, "ALBARAKA TÜRK KATILIM BANKASI A.Ş.", 432285, "GOLD", "VISA", "no", "no" },
                    { 369, 203, "ALBARAKA TÜRK KATILIM BANKASI A.Ş.", 534264, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 370, 203, "ALBARAKA TÜRK KATILIM BANKASI A.Ş.", 547234, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 371, 203, "ALBARAKA TÜRK KATILIM BANKASI A.Ş.", 548232, "GOLD", "MASTERCARD", "no", "no" },
                    { 372, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 402589, "CLASSIC", "VISA", "no", "no" },
                    { 373, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 402590, "GOLD", "VISA", "no", "no" },
                    { 374, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 402592, "BUSINESS", "VISA", "no", "no" },
                    { 375, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 403360, "PLATINUM", "VISA", "no", "no" },
                    { 376, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 403810, "BUSINESS", "VISA", "no", "no" },
                    { 377, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 410555, "CLASSIC", "VISA", "no", "no" },
                    { 378, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 410556, "CLASSIC", "VISA", "no", "no" },
                    { 379, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 424487, "Acquiring", "VISA", "no", "no" },
                    { 380, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 431024, "BUSINESS", "VISA", "no", "no" },
                    { 381, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 511660, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 382, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 512595, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 383, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 518896, "GOLD", "MASTERCARD", "no", "no" },
                    { 384, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 520180, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 385, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 547564, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 386, 205, "KUVEYT TÜRK KATILIM BANKASI A.Ş.", 525312, "MIXED PRODUCT", "MASTERCARD", "no", "no" },
                    { 387, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 404952, "CLASSIC", "VISA", "no", "no" },
                    { 388, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 411685, "BUSINESS", "VISA", "no", "no" },
                    { 389, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 428462, "CLASSIC", "VISA", "no", "no" },
                    { 390, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 435627, "CLASSIC", "VISA", "no", "no" },
                    { 391, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 435628, "GOLD", "VISA", "no", "no" },
                    { 392, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 521848, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 393, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 537719, "GOLD", "MASTERCARD", "no", "no" },
                    { 394, 206, "TÜRKİYE FİNANS KATILIM BANKASI A.Ş.", 549294, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 395, 208, "ASYA KATILIM BANKASI A.Ş.", 402275, "CLASSIC", "VISA", "no", "no" },
                    { 396, 208, "ASYA KATILIM BANKASI A.Ş.", 402276, "GOLD", "VISA", "no", "no" },
                    { 397, 208, "ASYA KATILIM BANKASI A.Ş.", 402280, "CLASSIC", "VISA", "no", "no" },
                    { 398, 208, "ASYA KATILIM BANKASI A.Ş.", 416987, "BUSINESS", "VISA", "no", "no" },
                    { 399, 208, "ASYA KATILIM BANKASI A.Ş.", 441033, "CLASSIC", "VISA", "no", "no" },
                    { 400, 208, "ASYA KATILIM BANKASI A.Ş.", 515849, "GOLD", "MASTERCARD", "no", "no" },
                    { 401, 208, "ASYA KATILIM BANKASI A.Ş.", 524384, "PLATINUM", "MASTERCARD", "no", "no" },
                    { 402, 208, "ASYA KATILIM BANKASI A.Ş.", 527585, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 403, 208, "ASYA KATILIM BANKASI A.Ş.", 529462, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 404, 208, "ASYA KATILIM BANKASI A.Ş.", 531334, "CLASSIC", "MASTERCARD", "no", "no" },
                    { 405, 208, "ASYA KATILIM BANKASI A.Ş.", 547799, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 406, 208, "ASYA KATILIM BANKASI A.Ş.", 552529, "BUSINESS", "MASTERCARD", "no", "no" },
                    { 407, 900, "PROVUS BİLİŞİM ", 492192, "Acquiring", "VISA", "no", "no" },
                    { 408, 900, "PROVUS BİLİŞİM ", 512446, "GOLD", "MASTERCARD", "no", "no" },
                    { 409, 900, "PROVUS BİLİŞİM ", 515865, "GOLD", "MASTERCARD", "no", "no" },
                    { 410, 900, "PROVUS BİLİŞİM ", 520909, "CLASSIC", "MASTERCARD", "no", "no" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Bins",
                keyColumn: "Id",
                keyValue: 410);
        }
    }
}
