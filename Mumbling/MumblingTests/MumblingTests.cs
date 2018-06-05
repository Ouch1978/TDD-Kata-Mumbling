using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mumbling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling.Tests
{
    [TestClass()]
    public class MumblingTests
    {
        [TestMethod()]
        public void MumblingTest()
        {
            Accumul.Accum( "ab" ).Should().Be( "A-Bb" );
        }

        [TestMethod()]
        public void MumblingTest0()
        {
            Accumul.Accum( "abc" ).Should().Be( "A-Bb-Ccc" );
        }

        [TestMethod()]
        public void MumblingTest1()
        {
            Accumul.Accum( "ZpglnRxqenU" ).Should().Be( "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu" );
        }

        [TestMethod()]
        public void MumblingTest2()
        {
            Accumul.Accum( "NyffsGeyylB" ).Should().Be( "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb" );
        }

        [TestMethod()]
        public void MumblingTest3()
        {
            Accumul.Accum( "MjtkuBovqrU" ).Should().Be( "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu" );
        }

        [TestMethod()]
        public void MumblingTest4()
        {
            Accumul.Accum( "EvidjUnokmM" ).Should().Be( "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm" );
        }

        [TestMethod()]
        public void MumblingTest5()
        {
            Accumul.Accum( "HbideVbxncC" ).Should().Be( "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc" );
        }
    }
}