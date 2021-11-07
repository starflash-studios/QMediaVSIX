// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel
{
  /// <summary>Provides an interface definition for the AppInfo class.</summary>
  [Guid(3474946090, 58507, 20236, 155, 11, 121, 195, 248, 149, 125, 215)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (AppInfo))]
  internal interface IAppInfoStatics
  {
    /// <summary>Provides an interface definition for the AppInfo.Current method.</summary>
    /// <returns>The AppInfo that corresponds to the currently running process.</returns>
    AppInfo Current { get; }

    /// <summary>Provides an interface definition for the AppInfo.GetFromAppUserModelId method.</summary>
    /// <param name="appUserModelId">The AUMID to retrieve the AppInfo from.</param>
    /// <returns>The AppInfo corresponding to the given AUMID.</returns>
    AppInfo GetFromAppUserModelId(string appUserModelId);

    /// <summary>Provides an interface definition for the AppInfo.GetFromAppUserModelIdForUser method.</summary>
    /// <param name="user">The User whose AppInfos you wish to access.</param>
    /// <param name="appUserModelId">The AUMID to retrieve the AppInfo from.</param>
    /// <returns>The AppInfo corresponding to the given AUMID and user.</returns>
    AppInfo GetFromAppUserModelIdForUser(User user, string appUserModelId);
  }
}
