﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class Information
    {
        public string MainMenu { get; private set; } = "\n 目標: 打敗怪物龍\n Press 1 →顯示玩家資訊\n Press 2 →顯示玩家背包資訊\n Press 3 →顯示怪物資訊/(挑選怪獸)進入戰鬥";
        public string BattleMenu { get; private set; } = "\n Press 1 →武器攻擊\n Press 2 →使用道具\n Press 3 →逃跑\n Press 4 →發呆\n";
        public string DeadMenu { get; private set; } = "在戰鬥中死亡";
        public string ChooseRole { get; private set; } = "選擇角色 1. 劍士  2. 斧頭戰士  3. 弓箭手  4. 赤手空拳 ";


        public void ShowInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}
