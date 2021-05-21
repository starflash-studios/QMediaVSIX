#region Copyright (C) 2017-2020  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.i18n.ja_JP {
    public class AppTranslations_Japanese : AppTranslations {

        public override Lang In_Lang => TransUtil.JaJP;

        public override (string, string) In_Toolbar { get; } = (
            "QMediaVSIXのツールバー",
            "QMediaVSIX"
        );

        public override (string, string, string) In_CmdMediaInfo { get; } = (
            "情報",
            "メディア再生情報",
            "現在再生中のメディアに関する情報を受信します。"
        );

        public override (string, string, string) In_CmdSkipRev { get; } = (
            "前",
            "前のメディア",
            "前の再生メディアにスキップします。"
        );

        public override (string, string, string) In_CmdPlayPause { get; } = (
            "プレイ・ポーズ",
            "プレイ・ポーズ",
            "再生・一時停止を切り替えります。"
        );

        public override (string, string, string) In_CmdSkipFwd { get; } = (
            "スキップ",
            "次のメディア",
            "次の再生メディアにスキップします。"
        );

        public override (string, string, string) In_CmdShuffle { get; } = (
            "シャッフル",
            "メディアのシャッフル",
            "メディアのシャッフルをトグルします。"
        );

        public override (string, string, string) In_CmdRepeat { get; } = (
            "リピート",
            "メディアのリピート",
            "メディアのリピートをトグルします。"
        );
    }
}