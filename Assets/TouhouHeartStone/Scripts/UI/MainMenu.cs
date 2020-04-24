﻿namespace UI
{
    partial class MainMenu
    {
        partial void onAwake()
        {
            ManMachineButton.onClick.AddListener(() =>
            {
                parent.game.startGame();
            });
            BuildButton.onClick.AddListener(() =>
            {
                parent.display(parent.Build);
            });
        }
    }
}
