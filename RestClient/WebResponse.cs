using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class WebResponse
{
    public int status;
    public string message;

    public bool IsSuccess()
    {
        return 1 == status;
    }

    public bool IsUnauthorized()
    {
        return status == 401;
    }

    public string GetMessage()
    {
        return message;
    }
}
