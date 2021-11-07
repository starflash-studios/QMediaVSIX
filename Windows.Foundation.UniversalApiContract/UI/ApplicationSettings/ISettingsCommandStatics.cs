// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ISettingsCommandStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [Guid(1956309332, 12137, 19223, 138, 186, 208, 92, 229, 119, 142, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SettingsCommand))]
  internal interface ISettingsCommandStatics
  {
    SettingsCommand AccountsCommand { get; }
  }
}
