

// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Test
{
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.12.1.0")]
    public enum TestEnum
    {
        EnumVal1,
        EnumVal2,
        EnumVal3,
    }

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.12.1.0")]
    public partial class Simple
    {
        [global::Bond.Id(0)]
        public int someInt { get; init; }

        [global::Bond.Id(1)]
        public int anotherInt { get; init; }

        [global::Bond.Id(2), global::Bond.Type(typeof(global::Bond.Tag.wstring))]
        public string someString { get; init; }

        public Simple(
            int someInt,
            int anotherInt,
            string someString)
        {
            this.someInt = someInt;
            this.anotherInt = anotherInt;
            this.someString = someString;
        }

        public Simple()
        {
            someString = "";
        }
    }

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.12.1.0")]
    public partial class Foo
    {
        [global::Bond.Id(0), global::Bond.Type(typeof(global::Bond.Tag.wstring))]
        public string someText { get; init; }

        public Foo(
            string someText)
        {
            this.someText = someText;
        }

        public Foo()
        {
            someText = "BaseText1";
        }
    }

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.12.1.0")]
    public partial class Bar
        : Foo
    {
        [global::Bond.Id(0)]
        public TestEnum testEnum { get; init; }

        [global::Bond.Id(1), global::Bond.Type(typeof(global::Bond.Tag.wstring))]
        new public string someText { get; init; }

        [global::Bond.Id(2)]
        public int someInt { get; init; }

        [global::Bond.Id(3), global::Bond.Type(typeof(global::Bond.Tag.wstring))]
        public string moreText { get; init; }

        [global::Bond.Id(4)]
        public List<Simple> someList { get; init; }

        [global::Bond.Id(5), global::Bond.Type(typeof(Dictionary<global::Bond.Tag.wstring, double>))]
        public Dictionary<string, double> someMap { get; init; }

        [global::Bond.Id(6), global::Bond.Type(typeof(HashSet<global::Bond.Tag.wstring>))]
        public HashSet<string> someSet { get; init; }

        public Bar(
            // Base class parameters
            string someText,

            // This class parameters
            TestEnum testEnum,
            string someText0,
            int someInt,
            string moreText,
            List<Simple> someList,
            Dictionary<string, double> someMap,
            HashSet<string> someSet
        ) : base(
                someText)
        {
            this.testEnum = testEnum;
            this.someText = someText0;
            this.someInt = someInt;
            this.moreText = moreText;
            this.someList = someList;
            this.someMap = someMap;
            this.someSet = someSet;
        }

        public Bar()
        {
            testEnum = TestEnum.Val2;
            someText = "DerivedText1";
            moreText = "";
            someList = new List<Simple>();
            someMap = new Dictionary<string, double>();
            someSet = new HashSet<string>();
        }
    }

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.12.1.0")]
    public partial class Baz
        : Bar
    {
        [global::Bond.Id(0), global::Bond.Type(typeof(global::Bond.Tag.wstring))]
        new public string someText { get; init; }

        [global::Bond.Id(1), global::Bond.Type(typeof(global::Bond.Tag.wstring))]
        public string evenMoreText { get; init; }

        [global::Bond.Id(2), global::Bond.Type(typeof(global::Bond.Tag.wstring))]
        public string someText1 { get; init; }

        public Baz(
            // Base class parameters
            string someText,
            TestEnum testEnum,
            string someText0,
            int someInt,
            string moreText,
            List<Simple> someList,
            Dictionary<string, double> someMap,
            HashSet<string> someSet,

            // This class parameters
            string someText1,
            string evenMoreText,
            string someText10
        ) : base(
                someText,
                testEnum,
                someText0,
                someInt,
                moreText,
                someList,
                someMap,
                someSet)
        {
            this.someText = someText1;
            this.evenMoreText = evenMoreText;
            this.someText1 = someText10;
        }

        public Baz()
        {
            someText = "";
            evenMoreText = "";
            someText1 = "";
        }
    }

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.12.1.0")]
    public partial class DerivedEmpty
        : Foo
    {
        

        public DerivedEmpty(
            // Base class parameters
            string someText
        ) : base(
                someText)
        {
            
        }

        public DerivedEmpty()
        {
            
        }
    }
} // Test
