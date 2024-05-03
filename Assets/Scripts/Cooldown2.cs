using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cooldown2 : MonoBehaviour
{

    [SerializeField] private float cooldownTime;
    private float _nextFiretime;

    public bool isCoolingDown => Time.time < _nextFiretime;

    public void StartCooldown() => _nextFiretime = Time.time + cooldownTime;



}