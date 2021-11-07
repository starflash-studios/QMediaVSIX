// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPaneCommandsRequestedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AccountsSettingsPaneCommandsRequestedEventArgs))]
  [Guid(909081517, 20023, 18791, 140, 64, 231, 142, 231, 161, 229, 187)]
  internal interface IAccountsSettingsPaneCommandsRequestedEventArgs2
  {
    User User { get; }
  }
}
