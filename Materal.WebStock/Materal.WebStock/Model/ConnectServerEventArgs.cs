﻿using MateralTools.Base.Manager;
using System;

namespace Materal.WebStock.Model
{
    /// <inheritdoc />
    /// <summary>
    /// 连接服务器时间参数组
    /// </summary>
    public class ConnectServerEventArgs : EventArgs
    {
        /// <summary>
        /// 连接消息
        /// </summary>
        public string Message => State.MGetDescription();

        /// <summary>
        /// 状态
        /// </summary>
        public ClientStateEnum State { get; set; }
    }
}
