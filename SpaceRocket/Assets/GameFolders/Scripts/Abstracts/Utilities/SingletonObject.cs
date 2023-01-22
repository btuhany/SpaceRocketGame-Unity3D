using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonObject<T> : MonoBehaviour
{
    public static T Instance { get; private set; } //statics are single
    protected void SingletonThisGameObject(T entity)
    {
        if (Instance == null)
        {
            Instance = entity;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
