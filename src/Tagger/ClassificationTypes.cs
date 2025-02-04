﻿using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace RainbowBraces
{
    public class ClassificationTypes
    {
        public static string GetName(int level, int cycleLength)
        {
            int mod = level % cycleLength;

            if (mod == 0)
            {
                mod = cycleLength;
            }

            return mod switch
            {
                1 => Level1,
                2 => Level2,
                3 => Level3,
                4 => Level4,
                5 => Level5,
                6 => Level6,
                7 => Level7,
                8 => Level8,
                _ => Level9,
            };
        }

        public const string Level1 = "Rainbow Brace level 1";
        public const string Level2 = "Rainbow Brace level 2";
        public const string Level3 = "Rainbow Brace level 3";
        public const string Level4 = "Rainbow Brace level 4";
        public const string Level5 = "Rainbow Brace level 5";
        public const string Level6 = "Rainbow Brace level 6";
        public const string Level7 = "Rainbow Brace level 7";
        public const string Level8 = "Rainbow Brace level 8";
        public const string Level9 = "Rainbow Brace level 9";

        [Export, Name(Level1)]
        internal static ClassificationTypeDefinition Level1Classification = null;

        [Export, Name(Level2)]
        internal static ClassificationTypeDefinition Level2Classification = null;

        [Export, Name(Level3)]
        internal static ClassificationTypeDefinition Level3Classification = null;

        [Export, Name(Level4)]
        internal static ClassificationTypeDefinition Level4Classification = null;

        [Export, Name(Level5)]
        internal static ClassificationTypeDefinition Level5Classification = null;

        [Export, Name(Level6)]
        internal static ClassificationTypeDefinition Level6Classification = null;

        [Export, Name(Level7)]
        internal static ClassificationTypeDefinition Level7Classification = null;

        [Export, Name(Level8)]
        internal static ClassificationTypeDefinition Level8Classification = null;

        [Export, Name(Level9)]
        internal static ClassificationTypeDefinition Level9Classification = null;
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level1)]
    [Name(ClassificationTypes.Level1)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level1 : ClassificationFormatDefinition
    {
        public Level1()
        {
            ForegroundColor = Color.FromArgb(0xff, 0xff, 0x99, 0x00);
            DisplayName = ClassificationTypes.Level1;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level2)]
    [Name(ClassificationTypes.Level2)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level2 : ClassificationFormatDefinition
    {
        public Level2()
        {
            ForegroundColor = Colors.OrangeRed;
            DisplayName = ClassificationTypes.Level2;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level3)]
    [Name(ClassificationTypes.Level3)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level3 : ClassificationFormatDefinition
    {
        public Level3()
        {
            ForegroundColor = Colors.PaleVioletRed;
            DisplayName = ClassificationTypes.Level3;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level4)]
    [Name(ClassificationTypes.Level4)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level4 : ClassificationFormatDefinition
    {
        public Level4()
        {
            ForegroundColor = Colors.OliveDrab;
            DisplayName = ClassificationTypes.Level4;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level5)]
    [Name(ClassificationTypes.Level5)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level5 : ClassificationFormatDefinition
    {
        public Level5()
        {
            ForegroundColor = Colors.OliveDrab;
            DisplayName = ClassificationTypes.Level5;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level6)]
    [Name(ClassificationTypes.Level6)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level6 : ClassificationFormatDefinition
    {
        public Level6()
        {
            ForegroundColor = Colors.OliveDrab;
            DisplayName = ClassificationTypes.Level6;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level7)]
    [Name(ClassificationTypes.Level7)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level7 : ClassificationFormatDefinition
    {
        public Level7()
        {
            ForegroundColor = Colors.OliveDrab;
            DisplayName = ClassificationTypes.Level7;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level8)]
    [Name(ClassificationTypes.Level8)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level8 : ClassificationFormatDefinition
    {
        public Level8()
        {
            ForegroundColor = Colors.OliveDrab;
            DisplayName = ClassificationTypes.Level8;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationTypes.Level9)]
    [Name(ClassificationTypes.Level9)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class Level9 : ClassificationFormatDefinition
    {
        public Level9()
        {
            ForegroundColor = Colors.OliveDrab;
            DisplayName = ClassificationTypes.Level9;
        }
    }
}
