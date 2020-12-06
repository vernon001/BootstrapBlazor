﻿// **********************************
// 框架名称：BootstrapBlazor 
// 框架作者：Argo Zhang
// 开源地址：
// Gitee : https://gitee.com/LongbowEnterprise/BootstrapBlazor
// GitHub: https://github.com/ArgoZhang/BootstrapBlazor 
// 开源协议：LGPL-3.0 (https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/dev/LICENSE)
// **********************************

using BootstrapBlazor.Shared.Common;
using BootstrapBlazor.Shared.Pages.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BootstrapBlazor.Shared.Pages
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Alerts
    {
        [NotNull]
        private string? Title { get; set; }

        [NotNull]
        private string? SubTitle { get; set; }

        [NotNull]
        private string? BaseUsageText { get; set; }

        [NotNull]
        private string? IntroText1 { get; set; }

        [NotNull]
        private string? AlertPrimaryText { get; set; }

        [NotNull]
        private string? AlertSecondaryText { get; set; }

        [NotNull]
        private string? AlertSuccessText { get; set; }

        [NotNull]
        private string? AlertDangerText { get; set; }

        [NotNull]
        private string? AlertWarningText { get; set; }

        [NotNull]
        private string? AlertInfoText { get; set; }

        [NotNull]
        private string? AlertDarkText { get; set; }

        [NotNull]
        private string? CloseButtonUsageText { get; set; }

        [NotNull]
        private string? IntroText2 { get; set; }

        [NotNull]
        private string? WithIconUsageText { get; set; }

        [NotNull]
        private string? IntroText3 { get; set; }

        [NotNull]
        private string? ShowBarUsageText { get; set; }

        [NotNull]
        private string? IntroText4 { get; set; }

        [Inject]
        [NotNull]
        private IStringLocalizer<Alerts>? Localizer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private Logger? Trace { get; set; }

        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Title ??= Localizer[nameof(Title)];
            SubTitle ??= Localizer[nameof(SubTitle)];
            BaseUsageText ??= Localizer[nameof(BaseUsageText)];
            IntroText1 ??= Localizer[nameof(IntroText1)];
            AlertPrimaryText ??= Localizer[nameof(AlertPrimaryText)];
            AlertSecondaryText ??= Localizer[nameof(AlertSecondaryText)];
            AlertDangerText ??= Localizer[nameof(AlertDangerText)];
            AlertSuccessText ??= Localizer[nameof(AlertSuccessText)];
            AlertWarningText ??= Localizer[nameof(AlertWarningText)];
            AlertInfoText ??= Localizer[nameof(AlertInfoText)];
            AlertDarkText ??= Localizer[nameof(AlertDarkText)];

            CloseButtonUsageText ??= Localizer[nameof(CloseButtonUsageText)];
            IntroText2 ??= Localizer[nameof(IntroText2)];

            WithIconUsageText ??= Localizer[nameof(WithIconUsageText)];
            IntroText3 ??= Localizer[nameof(IntroText3)];

            ShowBarUsageText ??= Localizer[nameof(ShowBarUsageText)];
            IntroText4 ??= Localizer[nameof(IntroText4)];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void DismissClick(MouseEventArgs e)
        {
            Trace?.Log($"Alert Dismissed");
        }

        /// <summary>
        /// 获得事件方法
        /// </summary>
        /// <returns></returns>
        private IEnumerable<EventItem> GetEvents() => new EventItem[]
        {
            new EventItem()
            {
                Name = "OnDismiss",
                Description="关闭警告框回调方法",
                Type ="EventCallback<MouseEventArgs>"
            }
        };

        /// <summary>
        /// 获得属性方法
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AttributeItem> GetAttributes() => new AttributeItem[]
        {
            // TODO: 移动到数据库中
            new AttributeItem() {
                Name = "ChildContent",
                Description = "内容",
                Type = "RenderFragment",
                ValueList = " — ",
                DefaultValue = " — "
            },
            new AttributeItem() {
                Name = "Class",
                Description = "样式",
                Type = "string",
                ValueList = " — ",
                DefaultValue = " — "
            },
            new AttributeItem() {
                Name = "Color",
                Description = "颜色",
                Type = "Color",
                ValueList = "Primary / Secondary / Success / Danger / Warning / Info / Dark",
                DefaultValue = "Primary"
            },
            new AttributeItem() {
                Name = "Icon",
                Description = "图标",
                Type = "string",
                ValueList = " — ",
                DefaultValue = " — "
            },
            new AttributeItem() {
                Name = "ShowDismiss",
                Description = "关闭按钮",
                Type = "bool",
                ValueList = " — ",
                DefaultValue = "false"
            },
            new AttributeItem() {
                Name = "ShowBar",
                Description = "是否显示左侧 Bar",
                Type = "bool",
                ValueList = "true|false",
                DefaultValue = "false"
            }
        };
    }
}
