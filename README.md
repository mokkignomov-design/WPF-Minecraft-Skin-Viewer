# 🧊 WPF Minecraft Skin Viewer

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Platform: .NET](https://img.shields.io/badge/Platform-.NET%206%2B-blue.svg)]()

Ультимативный и легкий компонент для отрисовки скинов Minecraft в приложениях WPF. Создан специально для тех, кто не хочет тянуть тяжелые движки ради одной модели персонажа.

## ✨ Особенности
* **Native WPF 3D**: Использует только встроенный `Viewport3D`. Никакого HelixToolkit или Unity.
* **Auto-detect Model**: Автоматически определяет тип скина (Slim/Classic) по прозрачности пикселей.
* **Overlays**: Полная поддержка второго слоя (одежда, аксессуары).
* **Smooth Animation**: Идеально плавное автовращение через `CompositionTarget.Rendering`.
* **Zero Dependencies**: Просто закинь один файл в проект.

## 🚀 Быстрый старт
1. Скопируйте файл `SkinView.cs` в ваш проект.
2. Подключите пространство имен в XAML:
```xml
xmlns:controls="clr-namespace:Runia.Ui.Pages.Controls"
