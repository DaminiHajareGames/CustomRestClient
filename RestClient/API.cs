using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class API
{
    const string base_url_iam = "https://0h29ute7nd.execute-api.ap-south-1.amazonaws.com/dev/mgp-iam/api/v1/";
    const string base_url_game = "https://0h29ute7nd.execute-api.ap-south-1.amazonaws.com/dev/mgp-game/api/v1/";
    //
    #region Before Auth
    #endregion

    #region After Auth
    public const string otp_send = base_url_iam + "auth/user/otp/send";
    public const string otp_verify = base_url_iam + "auth/user/otp/verify";
    public const string get_games_play_token = "https://0h29ute7nd.execute-api.ap-south-1.amazonaws.com/dev/mgp-game/api/v1/games/play/token";
    #endregion
}
