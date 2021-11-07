// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ISettingsCommandFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ApplicationSettings
{
  [Guid(1759599411, 7299, 17210, 170, 90, 206, 238, 165, 189, 71, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SettingsCommand))]
  internal interface ISettingsCommandFactory
  {
    SettingsCommand CreateSettingsCommand(
      [Variant] object settingsCommandId,
      string label,
      UICommandInvokedHandler handler);
  }
}
