// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextServicesManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Text.Core
{
  [Guid(3260054915, 28170, 19082, 189, 248, 25, 72, 135, 72, 84, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreTextServicesManager))]
  internal interface ICoreTextServicesManager
  {
    Language InputLanguage { get; }

    event TypedEventHandler<CoreTextServicesManager, object> InputLanguageChanged;

    CoreTextEditContext CreateEditContext();
  }
}
