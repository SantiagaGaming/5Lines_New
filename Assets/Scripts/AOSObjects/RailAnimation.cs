using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Анимация жд путей")]
public class RailAnimation : AosObjectBase
{
    [SerializeField] private RailsAnimation _rails;

    [AosAction(name: "Анимация влево исправны")]
    public void AnimateLeft()
    {
        _rails.PlayLeftOKAnimation();
    }
    [AosAction(name: "Анимация вправо исправны")]
    public void AnimateRight()
    {
        _rails.PlayRightOKAnimation();
    }

    [AosAction(name: "Анимация влево сломаны")]
    public void AnimateLeftBroken()
    {
        _rails.PlayLeftBrokenAnimation();
    }
    [AosAction(name: "Анимация вправо сломаны")]
    public void AnimateRightBroken()
    {
        _rails.PlayRightBrokenAnimation();
    }
}