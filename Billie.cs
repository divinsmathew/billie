using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Billie
{
    public class Billie
    {
        private readonly BillieData Parameters;
        public Billie(BillieData Parameters)
        {
            this.Parameters = Parameters;
        }

        private string ToLetters(int num)
        {
            var mod = num % 26;
            var pow = num / 26 | 0;
            string rem;
            if (mod != 0)
                rem = ((char)(64 + mod)).ToString();
            else
            {
                pow--;
                rem = "Z";
            }
            return pow != 0? ToLetters(pow) + rem : rem;
        }

        public string GenerateBreakdown()
        {
            using (var workbook = new XLWorkbook())
            {
                int i;
                int columnAlphaCount = 2;
                IXLCell ActiveCell;
                var worksheet = workbook.Worksheets.Add("Bill Breakdown");

                worksheet.Cell("A1").Value = Parameters.PurchaseDate.ToShortDateString().Replace("-", "/");
                MakeCell(worksheet.Cell("A1"), false, true, XLColor.FromArgb(200, 218, 247));
                worksheet.Cell("A2").Value = Parameters.ShopName;
                MakeCell(worksheet.Cell("A2"), true, true, XLColor.FromArgb(200, 218, 247));
                worksheet.Range("A2:A3").Merge();

                for (i = 0; i < Parameters.Items.Count; i++, columnAlphaCount++, columnAlphaCount++)
                {
                    worksheet.Range(ToLetters(columnAlphaCount) + "1:" + ToLetters(columnAlphaCount + 1) + "1").Merge();
                    worksheet.Cell(ToLetters(columnAlphaCount) + "1").Value = Parameters.Items[i].Name;
                    MakeCell(worksheet.Cell(ToLetters(columnAlphaCount) + "1"), true, true, XLColor.FromArgb(200, 218, 247));
                    MakeCell(worksheet.Cell(ToLetters(columnAlphaCount) + "1").CellRight(), true, true, XLColor.FromArgb(200, 218, 247));

                    worksheet.Range(ToLetters(columnAlphaCount) + "2:" + ToLetters(columnAlphaCount + 1).ToString() + "2").Merge();
                    worksheet.Cell(ToLetters(columnAlphaCount) + "2").Value = Parameters.Currency + " " + Parameters.Items[i].Price.ToString();
                    MakeCell(worksheet.Cell(ToLetters(columnAlphaCount) + "2"), true, true, XLColor.FromArgb(200, 218, 247));
                    MakeCell(worksheet.Cell(ToLetters(columnAlphaCount) + "2").CellRight(), true, true, XLColor.FromArgb(200, 218, 247));

                    worksheet.Cell(ToLetters(columnAlphaCount) + "3").Value = "Qty.";
                    MakeCell(worksheet.Cell(ToLetters(columnAlphaCount) + "3"), false, true, XLColor.FromArgb(200, 218, 247));
                    worksheet.Cell(ToLetters(columnAlphaCount + 1) + "3").Value = "Price (" + Parameters.Currency + ")";
                    MakeCell(worksheet.Cell(ToLetters(columnAlphaCount + 1).ToString() + "3"), false, true, XLColor.FromArgb(200, 218, 247));
                }

                if (Parameters.TaxPercentage > 0)
                {
                    MakeCell(worksheet.Cell(ToLetters(columnAlphaCount) + "1"), true, true, XLColor.FromArgb(200, 218, 247));
                    worksheet.Range(ToLetters(columnAlphaCount) + "1:" + ToLetters(columnAlphaCount) + "3").Merge();
                    worksheet.Cell(ToLetters(columnAlphaCount) + "1").Value = "Tax (" + Parameters.TaxPercentage + "%)";

                    columnAlphaCount++;
                }

                worksheet.Cell(ToLetters(columnAlphaCount) + "1").Value = "Total (" + Parameters.Currency + ")";
                MakeCell(worksheet.Cell(ToLetters(columnAlphaCount) + "1"), true, true, XLColor.FromArgb(200, 218, 247));
                worksheet.Range(ToLetters(columnAlphaCount) + "1:" + ToLetters(columnAlphaCount) + "3").Merge();

                worksheet.Cell(ToLetters(columnAlphaCount) + "2").Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                worksheet.Cell(ToLetters(columnAlphaCount) + "3").Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                worksheet.Cell(ToLetters(columnAlphaCount) + "2").Style.Border.SetOutsideBorderColor(XLColor.FromArgb(180, 195, 221));
                worksheet.Cell(ToLetters(columnAlphaCount) + "3").Style.Border.SetOutsideBorderColor(XLColor.FromArgb(180, 195, 221));

                for (i = 0; i < Parameters.PeopleNames.Count; i++)
                {
                    ActiveCell = worksheet.Cell("A" + (i + 4).ToString());
                    ActiveCell.Value = "  " + Parameters.PeopleNames[i];
                    MakeCell(ActiveCell, true, false, XLColor.FromArgb(217, 217, 217));
                }

                ActiveCell = worksheet.Cell("A" + (i + 4).ToString());
                ActiveCell.Value = "TOTAL";
                MakeCellRange(worksheet.Range("A" + (i + 4).ToString() + ":" + ToLetters(columnAlphaCount) + (i + 4).ToString()), true, true, XLColor.FromArgb(244, 204, 204));

                IXLRange Range = worksheet.Range("B" + (i + 4).ToString() + ":" + ToLetters(columnAlphaCount - ((Parameters.TaxPercentage > 0) ? 2 : 1)) + (i + 4).ToString());
                Range.Merge();
                Range.Style.Border.SetOutsideBorderColor(XLColor.FromArgb(180, 195, 221));

                worksheet.LastRowUsed(XLCellsUsedOptions.NormalFormats).Height = 30;

                double grandTotal = 0;
                double taxTotal = 0;
                List<string> TaxExcemptedItems = new List<string>();

                for (i = 0; i < Parameters.PeopleNames.Count; i++)
                {
                    double Total = 0;
                    double TaxReducedTotal = 0;
                    for (int j = 0; j < Parameters.Maps[i].Items.Count; j++)
                        for (int k = 0; k < Parameters.Items.Count; k++)
                            if (Parameters.Maps[i].Items[j] == Parameters.Items[k].Name)
                            {
                                ActiveCell = worksheet.Cell(((char)(k * 2 + 66)).ToString() + (i + 4).ToString());
                                if (Parameters.Maps[i].Denominators[j] == 1)
                                    ActiveCell.SetValue(Parameters.Maps[i].Quantities[j]);
                                else
                                    ActiveCell.SetValue(Parameters.Maps[i].Quantities[j].ToString() + "/" + Parameters.Maps[i].Denominators[j].ToString());
                                ActiveCell.CellRight().Value = ((Parameters.Maps[i].Quantities[j] * Parameters.Items[k].Price) / Parameters.Maps[i].Denominators[j]).ToString();
                                Total += (Parameters.Maps[i].Quantities[j] * Parameters.Items[k].Price) / Parameters.Maps[i].Denominators[j];
                                if (Parameters.Items[k].TaxExcempted)
                                {
                                    if (!TaxExcemptedItems.Contains(Parameters.Items[k].Name))
                                        TaxExcemptedItems.Add(Parameters.Items[k].Name);
                                }
                                else
                                    TaxReducedTotal += (Parameters.Maps[i].Quantities[j] * Parameters.Items[k].Price) / Parameters.Maps[i].Denominators[j];
                            }

                    grandTotal += Total;

                    if (Parameters.TaxPercentage > 0)
                    {
                        ActiveCell = worksheet.Cell(ToLetters(columnAlphaCount - 1) + (i + 4).ToString());
                        ActiveCell.Value = ((Parameters.TaxPercentage / 100) * TaxReducedTotal).ToString();

                        ActiveCell = worksheet.Cell(ToLetters(columnAlphaCount) + (i + 4).ToString());
                        ActiveCell.Value = ((Parameters.TaxPercentage / 100) * TaxReducedTotal + Total).ToString();

                        taxTotal += (Parameters.TaxPercentage / 100) * TaxReducedTotal;
                    }
                    else
                    {
                        ActiveCell = worksheet.Cell(ToLetters(columnAlphaCount) + (i + 4).ToString());
                        ActiveCell.Value = Total.ToString();
                    }

                    MakeCellRange(worksheet.Range("B" + (i + 4).ToString() + ":" + ToLetters(columnAlphaCount) + (i + 4).ToString()), false, true, XLColor.FromArgb(239, 239, 239));
                }

                worksheet.Cell(ToLetters(columnAlphaCount) + (i + 4).ToString()).Value = (grandTotal + taxTotal).ToString();
                if (Parameters.TaxPercentage > 0)
                    worksheet.Cell(ToLetters(columnAlphaCount - 1) + (i + 4).ToString()).Value = taxTotal.ToString();

                AdjustContent(worksheet, columnAlphaCount, i + 3);

                if (TaxExcemptedItems.Count > 0)
                {
                    worksheet.Cell(ToLetters(columnAlphaCount + 1) + "1").Value = "Tax* (" + Parameters.TaxPercentage + "%)";
                    worksheet.Range("A" + (i + 5).ToString() + ":" + ToLetters(columnAlphaCount) + (i + 5).ToString()).Merge();
                    ActiveCell = worksheet.Cell("A" + (i + 5).ToString());
                    ActiveCell.Style.Font.SetItalic(true);
                    ActiveCell.Style.Font.SetFontSize(8);
                    ActiveCell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                    ActiveCell.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    ActiveCell.Value = "* The " + Parameters.TaxPercentage.ToString() + "% tax was not accounted for " + string.Join(", ", TaxExcemptedItems) + " in the calculations.";
                }

                string FileName = Parameters.ShopName + " - Bill Breakdown.xlsx";
                workbook.SaveAs(FileName);

                return FileName;
            }
        }

        private void AdjustContent(IXLWorksheet worksheet, int LastCol, int LastRow)
        {
            int maxWidth = 0;
            try
            {
                for (int i = 0; i < LastRow; i++)
                {
                    int len = worksheet.Column(1).Cell(i + 1).Value.ToString().Length;
                    if (len > maxWidth)
                        maxWidth = len;
                }
                worksheet.Column(1).Width = maxWidth + 1;

                int optimumWidth = 10;
                for (int Col = 2; Col <= LastCol; Col++, Col++)
                {
                    maxWidth = 0;
                    for (int i = 1; i <= LastRow; i++)
                    {
                        int len;
                        if (i < 3)
                            len = worksheet.Column(ToLetters(Col)).Cell(i).Value.ToString().Length / 2;
                        else
                        {
                            int len1 = worksheet.Column(ToLetters(Col)).Cell(i).Value.ToString().Length;
                            int len2 = worksheet.Column(ToLetters(Col + 1)).Cell(i).Value.ToString().Length;

                            len = len1 > len2 ? len1 : len2;
                        }

                        if (len > maxWidth)
                            maxWidth = len;
                    }

                    if (maxWidth > optimumWidth)
                    {
                        worksheet.Column(Col.ToString()).Width = maxWidth;
                        worksheet.Column(ToLetters(Col + 1)).Width = maxWidth;
                    }
                    else
                    {
                        worksheet.Column(ToLetters(Col)).Width = optimumWidth;
                        worksheet.Column(ToLetters(Col + 1)).Width = optimumWidth;
                    }
                }

                maxWidth = 0;
                for (int i = 0; i < LastRow; i++)
                {
                    int len = worksheet.Column(ToLetters(LastCol)).Cell(i + 1).Value.ToString().Length;
                    if (len > maxWidth)
                        maxWidth = len;
                }
                worksheet.Column(ToLetters(LastCol)).Width = maxWidth + 4;

                if (Parameters.TaxPercentage > 0)
                {
                    maxWidth = 0;
                    for (int i = 0; i < LastRow; i++)
                    {
                        int len = worksheet.Column(ToLetters(LastCol - 1)).Cell(i + 1).Value.ToString().Length;

                        if (len > maxWidth)
                            maxWidth = len;
                    }

                    worksheet.Column(ToLetters(LastCol - 1)).Width = maxWidth + 2;
                }
            }
            catch (Exception e)
            {
                
            }
        }

        private void MakeCell(IXLCell Cell, bool Bold, bool Center, XLColor Color)
        {
            if (Bold)
                Cell.Style.Font.SetBold();

            if (Center)
                Cell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            Cell.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            Cell.Style.Fill.SetBackgroundColor(Color);
            Cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            Cell.Style.Border.SetOutsideBorderColor(XLColor.FromArgb(180, 195, 221));
        }

        private void MakeCellRange(IXLRange Range, bool Bold, bool Center, XLColor Color)
        {
            foreach (IXLCell Cell in Range.Cells())
            {
                if (Bold)
                    Cell.Style.Font.SetBold();

                if (Center)
                    Cell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                Cell.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                Cell.Style.Fill.SetBackgroundColor(Color);
                Cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                Cell.Style.Border.SetOutsideBorderColor(XLColor.FromArgb(180, 195, 221));
            }
        }
    }

    public class PersonItemMap
    {
        public int PersonIndex;
        public List<string> Items;
        public List<double> Quantities;
        public List<double> Denominators;

        public PersonItemMap()
        {
            Items = new List<string>();
            Quantities = new List<double>();
            Denominators = new List<double>();
        }
    }

    public class BillieData
    {
        public List<string> PeopleNames;
        public List<ItemDetails> Items;
        public List<PersonItemMap> Maps;
        public DateTime PurchaseDate;
        public double TaxPercentage;
        public string ShopName;
        public string Currency;

        public BillieData()
        {
            PeopleNames = new List<string>();
            Items = new List<ItemDetails>();
            Maps = new List<PersonItemMap>();
        }
    }

    public class ItemDetails
    {
        public string Name;
        public double Price;
        public bool TaxExcempted;
    }
}
