﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class View {
    static private int LabelWidth = 300;
    static private int LabelHeight = 100;
    static public Rect LabelPos = new Rect(
        (Screen.width  - LabelWidth) / 2,
        (Screen.height  - LabelHeight) / 2,
        LabelWidth,
        LabelHeight
    );

    static private GUIStyle _labelStyle;
    static public GUIStyle LabelStyle() {
        if (_labelStyle == null) {
            _labelStyle = new GUIStyle("Label");
            _labelStyle.fontSize = 60;
            _labelStyle.alignment = TextAnchor.MiddleCenter;
        }
        return _labelStyle;
    }

    //重新开始按钮
    static private GUIStyle _buttonStyle;
    static public GUIStyle ButtonStyle() {
        if(_buttonStyle == null) {
            _buttonStyle = new GUIStyle("Button");
            _buttonStyle.fontSize = 20;
        }
        return _buttonStyle;
    }
    static public Rect buttonPos = new Rect(
        10,   // 横坐标
        50,   // 纵坐标
        130,  // 长
        30    // 高
    );

    // 分数展示面板
    static private GUIStyle _scoreStyle;
    static public GUIStyle scoreStyle() {
        if (_scoreStyle == null) {
            _scoreStyle = new GUIStyle("Button");
            _scoreStyle.fontSize = 20;
        }
        return _buttonStyle;
    }
    static public Rect scorePos = new Rect(
        10,   // 横坐标
        20,   // 纵坐标
        130,  // 长
        30    // 高
    );
}
