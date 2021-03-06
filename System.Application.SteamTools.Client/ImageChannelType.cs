﻿using System.Application;
using System.Application.Services;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Application
{
    /// <summary>
    /// 图片下载渠道类型
    /// </summary>
    public enum ImageChannelType
    {
        /// <summary>
        /// Steam 头像图片
        /// </summary>
        SteamAvatars,

        /// <summary>
        /// Steam 游戏图片
        /// </summary>
        SteamGames,

        /// <summary>
        /// 验证码图片
        /// </summary>
        CodeImage,
    }
}

namespace System
{
    public static class ImageChannelTypeEnumExtensions
    {
        /// <inheritdoc cref="IHttpService.GetImageAsync(string, string, CancellationToken)"/>
        public static Task<Stream?> GetImageAsync(this IHttpService httpService,
            string requestUri,
            ImageChannelType channelType,
            CancellationToken cancellationToken = default)
        {
            var channelType_ = channelType.ToString();
            return httpService.GetImageAsync(requestUri, channelType_, cancellationToken);
        }
    }
}