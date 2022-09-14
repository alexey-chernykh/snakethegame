using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class Localization
    {
        public Language language { get; private set; }

        private List<Strings> UkrainianStrings;
        private List<Strings> EnglishStrings;
        private List<Strings> JapaneseStrings;
        public Localization()
        {
            UkrainianStrings = new List<Strings>()
            {
                new Strings("labelTitle", "  Гра в змійку"),
                new Strings("buttonPlay", "Грати"),
                new Strings("buttonSettings", "Налаштування"),
                new Strings("buttonScoreboard", "Рекорди"),
                new Strings("buttonExit", "Вихід"),
                new Strings("labelDifficult", "Складність:"),
                new Strings("buttonEasy", "Легко"),
                new Strings("buttonNormal", "Норма"),
                new Strings("buttonHard", "Важко"),
                new Strings("labelTheme", "   Тема:"),
                new Strings("buttonStandard", "Стандартна"),
                new Strings("buttonNeon", "Неонова"),
                new Strings("buttonDark", "Класична"),
                new Strings("labelPlace", "Місце:"),
                new Strings("labelScorePlace", "Рахунок:"),
                new Strings("labelDeath", "Ви програли!"),
                new Strings("labelCopyright", "Авторське право © 2022. Всі права захищені."),
                new Strings("buttonTryAgain", "Нова спроба"),
                new Strings("buttonReturn", "Повернутися до меню"),
                new Strings("labelScore", "Рахунок: ")
            };
            EnglishStrings = new List<Strings>()
            {
                new Strings("labelTitle", "Snake The Game"),
                new Strings("buttonPlay", "Play"),
                new Strings("buttonSettings", "Settings"),
                new Strings("buttonScoreboard", "Scoreboard"),
                new Strings("buttonExit", "Exit"),
                new Strings("labelDifficult", "Difficulty:"),
                new Strings("buttonEasy", "Easy"),
                new Strings("buttonNormal", "Normal"),
                new Strings("buttonHard", "Hard"),
                new Strings("labelTheme", "Theme:"),
                new Strings("buttonStandard", "Standard"),
                new Strings("buttonNeon", "Neon"),
                new Strings("buttonDark", "Classic"),
                new Strings("labelPlace", "Place:"),
                new Strings("labelScorePlace", "Score:"),
                new Strings("labelDeath", "You failed!"),
                new Strings("labelCopyright", "Copyright © 2022. All Rights Reserved."),
                new Strings("buttonTryAgain", "Try Again"),
                new Strings("buttonReturn", "Return to Menu"),
                new Strings("labelScore", "Score: ")

            };
            JapaneseStrings = new List<Strings>()
            {
                new Strings("labelTitle", "   ヘビゲーム"),
                new Strings("buttonPlay", "遊ぶ"),
                new Strings("buttonSettings", "設定"),
                new Strings("buttonScoreboard", "スコアボード"),
                new Strings("buttonExit", "出口"),
                new Strings("labelDifficult", "    困難:"),
                new Strings("buttonEasy", "簡単"),
                new Strings("buttonNormal", "普通"),
                new Strings("buttonHard", "難しい"),
                new Strings("labelTheme", "テーマ:"),
                new Strings("buttonStandard", "標準"),
                new Strings("buttonNeon", "ネオン"),
                new Strings("buttonDark", "クラシック"),
                new Strings("labelPlace", "場所:"),
                new Strings("labelScorePlace", "スコア:"),
                new Strings("labelDeath", "あなたが失敗した!"),
                new Strings("labelCopyright", "Copyright©2022。無断複写・転載を禁じます。"),
                new Strings("buttonTryAgain", "再試行する"),
                new Strings("buttonReturn", "メニューに戻る"),
                new Strings("labelScore", "スコア: ")

            };
            language = Language.English;
        }
        public void ChangeLanguage(Form form, Language lang)
        {
            language = lang;
            foreach (Control control in form.Controls)
            {
                switch (language)
                {
                    case Language.English:
                        foreach (Strings str in EnglishStrings)
                        {
                            if (control.Name == str.Name)
                            {
                                control.Text = str.Value;
                            }
                        }
                        break;
                    case Language.Ukrainian:
                        foreach (Strings str in UkrainianStrings)
                        {
                            if (control.Name == str.Name)
                            {
                                control.Text = str.Value;
                            }
                        }
                        break;
                    case Language.Japanese:
                        foreach (Strings str in JapaneseStrings)
                        {
                            if (control.Name == str.Name)
                            {
                                control.Text = str.Value;
                            }
                        }
                        break;
                    default:
                        break;
                }
                
               
            }
        }
    }
}
