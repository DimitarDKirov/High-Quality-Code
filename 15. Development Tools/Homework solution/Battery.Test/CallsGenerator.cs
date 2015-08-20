
using System;
using MobilePhones;

class CallsGenerator
        {
        		private DateTime refDate = new DateTime(2000, 1, 1);
		private Call[] calls=new Call[50];
		private CallsGenerator(){
                        calls[0]=  new Call(refDate.AddTicks(-824201470000000), "011918795", 2944);
                          calls[1]=  new Call(refDate.AddTicks(-316549660000000), "052128310", 223);
                          calls[2]=  new Call(refDate.AddTicks(-823051350000000), "068232563", 1760);
                          calls[3]=  new Call(refDate.AddTicks(-354782500000000), "086438521", 1354);
                          calls[4]=  new Call(refDate.AddTicks(-218463460000000), "050932275", 2529);
                          calls[5]=  new Call(refDate.AddTicks(501064410000000), "086290433", 2643);
                          calls[6]=  new Call(refDate.AddTicks(-617192140000000), "065918743", 2375);
                          calls[7]=  new Call(refDate.AddTicks(369994650000000), "084616168", 204);
                          calls[8]=  new Call(refDate.AddTicks(-171408030000000), "092811546", 3232);
                          calls[9]=  new Call(refDate.AddTicks(-206416720000000), "035958477", 3078);
                          calls[10]=  new Call(refDate.AddTicks(466062150000000), "013631632", 1707);
                          calls[11]=  new Call(refDate.AddTicks(-161079780000000), "092031787", 3480);
                          calls[12]=  new Call(refDate.AddTicks(-337616840000000), "062339841", 2225);
                          calls[13]=  new Call(refDate.AddTicks(-401928290000000), "068538023", 3012);
                          calls[14]=  new Call(refDate.AddTicks(820982730000000), "077611165", 2632);
                          calls[15]=  new Call(refDate.AddTicks(-33969650000000), "031132361", 643);
                          calls[16]=  new Call(refDate.AddTicks(34566690000000), "027548898", 785);
                          calls[17]=  new Call(refDate.AddTicks(28393010000000), "035370435", 2409);
                          calls[18]=  new Call(refDate.AddTicks(639630950000000), "047013578", 1554);
                          calls[19]=  new Call(refDate.AddTicks(-46916200000000), "032750013", 2829);
                          calls[20]=  new Call(refDate.AddTicks(162462490000000), "029486842", 682);
                          calls[21]=  new Call(refDate.AddTicks(-121211060000000), "082383185", 2011);
                          calls[22]=  new Call(refDate.AddTicks(143879460000000), "015197936", 2784);
                          calls[23]=  new Call(refDate.AddTicks(630142430000000), "050217972", 1476);
                          calls[24]=  new Call(refDate.AddTicks(531263360000000), "047574080", 1889);
                          calls[25]=  new Call(refDate.AddTicks(195399240000000), "078922673", 580);
                          calls[26]=  new Call(refDate.AddTicks(246767700000000), "023561961", 1854);
                          calls[27]=  new Call(refDate.AddTicks(-249244830000000), "026976868", 3022);
                          calls[28]=  new Call(refDate.AddTicks(-464485190000000), "029516758", 3343);
                          calls[29]=  new Call(refDate.AddTicks(-546891340000000), "068735424", 1015);
                          calls[30]=  new Call(refDate.AddTicks(-643199710000000), "029049782", 2391);
                          calls[31]=  new Call(refDate.AddTicks(-491587510000000), "077860918", 1450);
                          calls[32]=  new Call(refDate.AddTicks(679614260000000), "078155944", 3235);
                          calls[33]=  new Call(refDate.AddTicks(-646101320000000), "028477393", 3567);
                          calls[34]=  new Call(refDate.AddTicks(-639039110000000), "064281383", 2720);
                          calls[35]=  new Call(refDate.AddTicks(-132300980000000), "067841393", 1922);
                          calls[36]=  new Call(refDate.AddTicks(574680510000000), "028416720", 633);
                          calls[37]=  new Call(refDate.AddTicks(798575540000000), "092080141", 2096);
                          calls[38]=  new Call(refDate.AddTicks(-438615200000000), "062311364", 1564);
                          calls[39]=  new Call(refDate.AddTicks(-61005390000000), "067046395", 2999);
                          calls[40]=  new Call(refDate.AddTicks(-402718180000000), "093273411", 3035);
                          calls[41]=  new Call(refDate.AddTicks(159587170000000), "036565285", 2193);
                          calls[42]=  new Call(refDate.AddTicks(-101951070000000), "050104774", 3340);
                          calls[43]=  new Call(refDate.AddTicks(307240400000000), "019218327", 848);
                          calls[44]=  new Call(refDate.AddTicks(-3588270000000), "086477833", 872);
                          calls[45]=  new Call(refDate.AddTicks(652122290000000), "023352672", 919);
                          calls[46]=  new Call(refDate.AddTicks(-468347520000000), "086063969", 674);
                          calls[47]=  new Call(refDate.AddTicks(-165813230000000), "022320459", 2064);
                          calls[48]=  new Call(refDate.AddTicks(146841880000000), "014082270", 36);
                          calls[49]=  new Call(refDate.AddTicks(216318090000000), "059375817", 116);
          		}

			public Call[] Calls
			{
				get
				{
					return (Call[])calls.Clone();
				}
			}
        }
    