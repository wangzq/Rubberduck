//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Splinter\Documents\Visual Studio 2015\Projects\TestProj\TestProj\VBADate.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Rubberduck.Parsing.Date
{
    using Antlr4.Runtime;
    using Antlr4.Runtime.Atn;
    using Antlr4.Runtime.Misc;
    using DFA = Antlr4.Runtime.Dfa.DFA;

    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
    [System.CLSCompliant(false)]
    public partial class VBADateLexer : Lexer
    {
        public const int
            AMPM = 1, JANUARY = 2, FEBRUARY = 3, MARCH = 4, APRIL = 5, MAY = 6, JUNE = 7, JULY = 8,
            AUGUST = 9, SEPTEMBER = 10, OCTOBER = 11, NOVEMBER = 12, DECEMBER = 13, JAN = 14,
            FEB = 15, MAR = 16, APR = 17, JUN = 18, JUL = 19, AUG = 20, SEP = 21, OCT = 22, NOV = 23,
            DEC = 24, AM = 25, PM = 26, HASH = 27, COMMA = 28, DASH = 29, SLASH = 30, COLON = 31,
            DOT = 32, WS = 33, DIGIT = 34;
        public static string[] modeNames = {
        "DEFAULT_MODE"
    };

        public static readonly string[] tokenNames = {
        "'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'",
        "'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'",
        "'\r'", "'\\u000E'", "'\\u000F'", "'\\u0010'", "'\\u0011'", "'\\u0012'",
        "'\\u0013'", "'\\u0014'", "'\\u0015'", "'\\u0016'", "'\\u0017'", "'\\u0018'",
        "'\\u0019'", "'\\u001A'", "'\\u001B'", "'\\u001C'", "'\\u001D'", "'\\u001E'",
        "'\\u001F'", "' '", "'!'", "'\"'"
    };
        public static readonly string[] ruleNames = {
        "AMPM", "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY",
        "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER", "JAN", "FEB",
        "MAR", "APR", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC", "AM", "PM",
        "HASH", "COMMA", "DASH", "SLASH", "COLON", "DOT", "WS", "DIGIT", "A",
        "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
        "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
    };


        public VBADateLexer(ICharStream input)
            : base(input)
        {
            _interp = new LexerATNSimulator(this, _ATN);
        }

        public override string GrammarFileName { get { return "VBADate.g4"; } }

        public override string[] TokenNames { get { return tokenNames; } }

        public override string[] RuleNames { get { return ruleNames; } }

        public override string[] ModeNames { get { return modeNames; } }

        public override string SerializedAtn { get { return _serializedATN; } }

        public static readonly string _serializedATN =
            "\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2$\x14D\b\x1\x4\x2" +
            "\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4" +
            "\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10" +
            "\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15" +
            "\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B" +
            "\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!" +
            "\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t" +
            "*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32" +
            "\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37" +
            "\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x3\x2\x3\x2\x3" +
            "\x2\x3\x2\x5\x2\x80\n\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3" +
            "\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5" +
            "\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a" +
            "\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n" +
            "\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v" +
            "\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r" +
            "\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3" +
            "\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11" +
            "\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13" +
            "\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16" +
            "\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18" +
            "\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B" +
            "\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3" +
            "!\x3\"\x3\"\x3#\x3#\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3(\x3(\x3)\x3)" +
            "\x3*\x3*\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\x3\x31" +
            "\x3\x31\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35\x3\x35\x3\x36" +
            "\x3\x36\x3\x37\x3\x37\x3\x38\x3\x38\x3\x39\x3\x39\x3:\x3:\x3;\x3;\x3<" +
            "\x3<\x3=\x3=\x2\x2\x2>\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b" +
            "\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2" +
            "\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18" +
            "/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F" +
            "=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2\x2I\x2\x2K\x2\x2M\x2\x2O\x2\x2" +
            "Q\x2\x2S\x2\x2U\x2\x2W\x2\x2Y\x2\x2[\x2\x2]\x2\x2_\x2\x2\x61\x2\x2\x63" +
            "\x2\x2\x65\x2\x2g\x2\x2i\x2\x2k\x2\x2m\x2\x2o\x2\x2q\x2\x2s\x2\x2u\x2" +
            "\x2w\x2\x2y\x2\x2\x3\x2\x1E\x4\x2\v\v\"\"\x3\x2\x32;\x4\x2\x43\x43\x63" +
            "\x63\x4\x2\x44\x44\x64\x64\x4\x2\x45\x45\x65\x65\x4\x2\x46\x46\x66\x66" +
            "\x4\x2GGgg\x4\x2HHhh\x4\x2IIii\x4\x2JJjj\x4\x2KKkk\x4\x2LLll\x4\x2MMm" +
            "m\x4\x2NNnn\x4\x2OOoo\x4\x2PPpp\x4\x2QQqq\x4\x2RRrr\x4\x2SSss\x4\x2TT" +
            "tt\x4\x2UUuu\x4\x2VVvv\x4\x2WWww\x4\x2XXxx\x4\x2YYyy\x4\x2ZZzz\x4\x2[" +
            "[{{\x4\x2\\\\||\x135\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2" +
            "\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2" +
            "\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3" +
            "\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2" +
            "\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'" +
            "\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2" +
            "\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37" +
            "\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3" +
            "\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x3" +
            "\x7F\x3\x2\x2\x2\x5\x81\x3\x2\x2\x2\a\x89\x3\x2\x2\x2\t\x92\x3\x2\x2\x2" +
            "\v\x98\x3\x2\x2\x2\r\x9E\x3\x2\x2\x2\xF\xA2\x3\x2\x2\x2\x11\xA7\x3\x2" +
            "\x2\x2\x13\xAC\x3\x2\x2\x2\x15\xB3\x3\x2\x2\x2\x17\xBD\x3\x2\x2\x2\x19" +
            "\xC5\x3\x2\x2\x2\x1B\xCE\x3\x2\x2\x2\x1D\xD7\x3\x2\x2\x2\x1F\xDB\x3\x2" +
            "\x2\x2!\xDF\x3\x2\x2\x2#\xE3\x3\x2\x2\x2%\xE7\x3\x2\x2\x2\'\xEB\x3\x2" +
            "\x2\x2)\xEF\x3\x2\x2\x2+\xF3\x3\x2\x2\x2-\xF7\x3\x2\x2\x2/\xFB\x3\x2\x2" +
            "\x2\x31\xFF\x3\x2\x2\x2\x33\x103\x3\x2\x2\x2\x35\x106\x3\x2\x2\x2\x37" +
            "\x109\x3\x2\x2\x2\x39\x10B\x3\x2\x2\x2;\x10D\x3\x2\x2\x2=\x10F\x3\x2\x2" +
            "\x2?\x111\x3\x2\x2\x2\x41\x113\x3\x2\x2\x2\x43\x115\x3\x2\x2\x2\x45\x117" +
            "\x3\x2\x2\x2G\x119\x3\x2\x2\x2I\x11B\x3\x2\x2\x2K\x11D\x3\x2\x2\x2M\x11F" +
            "\x3\x2\x2\x2O\x121\x3\x2\x2\x2Q\x123\x3\x2\x2\x2S\x125\x3\x2\x2\x2U\x127" +
            "\x3\x2\x2\x2W\x129\x3\x2\x2\x2Y\x12B\x3\x2\x2\x2[\x12D\x3\x2\x2\x2]\x12F" +
            "\x3\x2\x2\x2_\x131\x3\x2\x2\x2\x61\x133\x3\x2\x2\x2\x63\x135\x3\x2\x2" +
            "\x2\x65\x137\x3\x2\x2\x2g\x139\x3\x2\x2\x2i\x13B\x3\x2\x2\x2k\x13D\x3" +
            "\x2\x2\x2m\x13F\x3\x2\x2\x2o\x141\x3\x2\x2\x2q\x143\x3\x2\x2\x2s\x145" +
            "\x3\x2\x2\x2u\x147\x3\x2\x2\x2w\x149\x3\x2\x2\x2y\x14B\x3\x2\x2\x2{\x80" +
            "\x5\x33\x1A\x2|\x80\x5\x35\x1B\x2}\x80\x5G$\x2~\x80\x5\x65\x33\x2\x7F" +
            "{\x3\x2\x2\x2\x7F|\x3\x2\x2\x2\x7F}\x3\x2\x2\x2\x7F~\x3\x2\x2\x2\x80\x4" +
            "\x3\x2\x2\x2\x81\x82\x5Y-\x2\x82\x83\x5G$\x2\x83\x84\x5\x61\x31\x2\x84" +
            "\x85\x5o\x38\x2\x85\x86\x5G$\x2\x86\x87\x5i\x35\x2\x87\x88\x5w<\x2\x88" +
            "\x6\x3\x2\x2\x2\x89\x8A\x5Q)\x2\x8A\x8B\x5O(\x2\x8B\x8C\x5I%\x2\x8C\x8D" +
            "\x5i\x35\x2\x8D\x8E\x5o\x38\x2\x8E\x8F\x5G$\x2\x8F\x90\x5i\x35\x2\x90" +
            "\x91\x5w<\x2\x91\b\x3\x2\x2\x2\x92\x93\x5_\x30\x2\x93\x94\x5G$\x2\x94" +
            "\x95\x5i\x35\x2\x95\x96\x5K&\x2\x96\x97\x5U+\x2\x97\n\x3\x2\x2\x2\x98" +
            "\x99\x5G$\x2\x99\x9A\x5\x65\x33\x2\x9A\x9B\x5i\x35\x2\x9B\x9C\x5W,\x2" +
            "\x9C\x9D\x5]/\x2\x9D\f\x3\x2\x2\x2\x9E\x9F\x5_\x30\x2\x9F\xA0\x5G$\x2" +
            "\xA0\xA1\x5w<\x2\xA1\xE\x3\x2\x2\x2\xA2\xA3\x5Y-\x2\xA3\xA4\x5o\x38\x2" +
            "\xA4\xA5\x5\x61\x31\x2\xA5\xA6\x5O(\x2\xA6\x10\x3\x2\x2\x2\xA7\xA8\x5" +
            "Y-\x2\xA8\xA9\x5o\x38\x2\xA9\xAA\x5]/\x2\xAA\xAB\x5w<\x2\xAB\x12\x3\x2" +
            "\x2\x2\xAC\xAD\x5G$\x2\xAD\xAE\x5o\x38\x2\xAE\xAF\x5S*\x2\xAF\xB0\x5o" +
            "\x38\x2\xB0\xB1\x5k\x36\x2\xB1\xB2\x5m\x37\x2\xB2\x14\x3\x2\x2\x2\xB3" +
            "\xB4\x5k\x36\x2\xB4\xB5\x5O(\x2\xB5\xB6\x5\x65\x33\x2\xB6\xB7\x5m\x37" +
            "\x2\xB7\xB8\x5O(\x2\xB8\xB9\x5_\x30\x2\xB9\xBA\x5I%\x2\xBA\xBB\x5O(\x2" +
            "\xBB\xBC\x5i\x35\x2\xBC\x16\x3\x2\x2\x2\xBD\xBE\x5\x63\x32\x2\xBE\xBF" +
            "\x5K&\x2\xBF\xC0\x5m\x37\x2\xC0\xC1\x5\x63\x32\x2\xC1\xC2\x5I%\x2\xC2" +
            "\xC3\x5O(\x2\xC3\xC4\x5i\x35\x2\xC4\x18\x3\x2\x2\x2\xC5\xC6\x5\x61\x31" +
            "\x2\xC6\xC7\x5\x63\x32\x2\xC7\xC8\x5q\x39\x2\xC8\xC9\x5O(\x2\xC9\xCA\x5" +
            "_\x30\x2\xCA\xCB\x5I%\x2\xCB\xCC\x5O(\x2\xCC\xCD\x5i\x35\x2\xCD\x1A\x3" +
            "\x2\x2\x2\xCE\xCF\x5M\'\x2\xCF\xD0\x5O(\x2\xD0\xD1\x5K&\x2\xD1\xD2\x5" +
            "O(\x2\xD2\xD3\x5_\x30\x2\xD3\xD4\x5I%\x2\xD4\xD5\x5O(\x2\xD5\xD6\x5i\x35" +
            "\x2\xD6\x1C\x3\x2\x2\x2\xD7\xD8\x5Y-\x2\xD8\xD9\x5G$\x2\xD9\xDA\x5\x61" +
            "\x31\x2\xDA\x1E\x3\x2\x2\x2\xDB\xDC\x5Q)\x2\xDC\xDD\x5O(\x2\xDD\xDE\x5" +
            "I%\x2\xDE \x3\x2\x2\x2\xDF\xE0\x5_\x30\x2\xE0\xE1\x5G$\x2\xE1\xE2\x5i" +
            "\x35\x2\xE2\"\x3\x2\x2\x2\xE3\xE4\x5G$\x2\xE4\xE5\x5\x65\x33\x2\xE5\xE6" +
            "\x5i\x35\x2\xE6$\x3\x2\x2\x2\xE7\xE8\x5Y-\x2\xE8\xE9\x5o\x38\x2\xE9\xEA" +
            "\x5\x61\x31\x2\xEA&\x3\x2\x2\x2\xEB\xEC\x5Y-\x2\xEC\xED\x5o\x38\x2\xED" +
            "\xEE\x5]/\x2\xEE(\x3\x2\x2\x2\xEF\xF0\x5G$\x2\xF0\xF1\x5o\x38\x2\xF1\xF2" +
            "\x5S*\x2\xF2*\x3\x2\x2\x2\xF3\xF4\x5k\x36\x2\xF4\xF5\x5O(\x2\xF5\xF6\x5" +
            "\x65\x33\x2\xF6,\x3\x2\x2\x2\xF7\xF8\x5\x63\x32\x2\xF8\xF9\x5K&\x2\xF9" +
            "\xFA\x5m\x37\x2\xFA.\x3\x2\x2\x2\xFB\xFC\x5\x61\x31\x2\xFC\xFD\x5\x63" +
            "\x32\x2\xFD\xFE\x5q\x39\x2\xFE\x30\x3\x2\x2\x2\xFF\x100\x5M\'\x2\x100" +
            "\x101\x5O(\x2\x101\x102\x5K&\x2\x102\x32\x3\x2\x2\x2\x103\x104\x5G$\x2" +
            "\x104\x105\x5_\x30\x2\x105\x34\x3\x2\x2\x2\x106\x107\x5\x65\x33\x2\x107" +
            "\x108\x5_\x30\x2\x108\x36\x3\x2\x2\x2\x109\x10A\a%\x2\x2\x10A\x38\x3\x2" +
            "\x2\x2\x10B\x10C\a.\x2\x2\x10C:\x3\x2\x2\x2\x10D\x10E\a/\x2\x2\x10E<\x3" +
            "\x2\x2\x2\x10F\x110\a\x31\x2\x2\x110>\x3\x2\x2\x2\x111\x112\a<\x2\x2\x112" +
            "@\x3\x2\x2\x2\x113\x114\a\x30\x2\x2\x114\x42\x3\x2\x2\x2\x115\x116\t\x2" +
            "\x2\x2\x116\x44\x3\x2\x2\x2\x117\x118\t\x3\x2\x2\x118\x46\x3\x2\x2\x2" +
            "\x119\x11A\t\x4\x2\x2\x11AH\x3\x2\x2\x2\x11B\x11C\t\x5\x2\x2\x11CJ\x3" +
            "\x2\x2\x2\x11D\x11E\t\x6\x2\x2\x11EL\x3\x2\x2\x2\x11F\x120\t\a\x2\x2\x120" +
            "N\x3\x2\x2\x2\x121\x122\t\b\x2\x2\x122P\x3\x2\x2\x2\x123\x124\t\t\x2\x2" +
            "\x124R\x3\x2\x2\x2\x125\x126\t\n\x2\x2\x126T\x3\x2\x2\x2\x127\x128\t\v" +
            "\x2\x2\x128V\x3\x2\x2\x2\x129\x12A\t\f\x2\x2\x12AX\x3\x2\x2\x2\x12B\x12C" +
            "\t\r\x2\x2\x12CZ\x3\x2\x2\x2\x12D\x12E\t\xE\x2\x2\x12E\\\x3\x2\x2\x2\x12F" +
            "\x130\t\xF\x2\x2\x130^\x3\x2\x2\x2\x131\x132\t\x10\x2\x2\x132`\x3\x2\x2" +
            "\x2\x133\x134\t\x11\x2\x2\x134\x62\x3\x2\x2\x2\x135\x136\t\x12\x2\x2\x136" +
            "\x64\x3\x2\x2\x2\x137\x138\t\x13\x2\x2\x138\x66\x3\x2\x2\x2\x139\x13A" +
            "\t\x14\x2\x2\x13Ah\x3\x2\x2\x2\x13B\x13C\t\x15\x2\x2\x13Cj\x3\x2\x2\x2" +
            "\x13D\x13E\t\x16\x2\x2\x13El\x3\x2\x2\x2\x13F\x140\t\x17\x2\x2\x140n\x3" +
            "\x2\x2\x2\x141\x142\t\x18\x2\x2\x142p\x3\x2\x2\x2\x143\x144\t\x19\x2\x2" +
            "\x144r\x3\x2\x2\x2\x145\x146\t\x1A\x2\x2\x146t\x3\x2\x2\x2\x147\x148\t" +
            "\x1B\x2\x2\x148v\x3\x2\x2\x2\x149\x14A\t\x1C\x2\x2\x14Ax\x3\x2\x2\x2\x14B" +
            "\x14C\t\x1D\x2\x2\x14Cz\x3\x2\x2\x2\x4\x2\x7F\x2";
        public static readonly ATN _ATN =
            new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
    }
} // namespace Rubberduck.Parsing.Date
