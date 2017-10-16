using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RoExecuter {
    class Program {
        static void Main( string[] args ) {
            String strFile = @"C:\Program Files (x86)\Gravity\RagnarokOnline\savedata\OptionInfo.lua";
            StreamReader reader = File.OpenText( strFile );
            StreamWriter writer = File.CreateText( strFile + "_" );
            string strLine = reader.ReadLine();
            while ( strLine != null ) {
                if ( strLine.IndexOf( "WIDTH" ) >= 0 ) {
                    int nIndex = strLine.IndexOf( "=" );
                    strLine = strLine.Substring( 0, nIndex + 2 );
                    strLine += args[ 0 ];
                }
                if ( strLine.IndexOf( "HEIGHT" ) >= 0 ) {
                    int nIndex = strLine.IndexOf( "=" );
                    strLine = strLine.Substring( 0, nIndex + 2 );
                    strLine += args[ 1 ];
                }
                writer.WriteLine( strLine );
                strLine = reader.ReadLine();
            }
            writer.Close();
            reader.Close();
            File.Delete( strFile );
            File.Move( strFile + "_", strFile );

            strFile = @"C:\Program Files (x86)\Gravity\RagnarokOnline\savedata\ChatWndInfo_U.lua";
            String strTemp = strFile + "_" + args[ 0 ] + "_" + args[ 1 ];
            if ( File.Exists( strTemp ) ) {
                File.Delete( strFile );
                File.Copy( strTemp, strFile );
            }

            Process.Start( @"C:\Program Files (x86)\Gravity\RagnarokOnline\Ragexe.exe", @"1free1 /account:clientinf0.xml" );
        }
    }
}