// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplication2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(26281150, 21034, 22788, 245, 47, 222, 114, 1, 4, 41, 224)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Application))]
  internal interface IApplication2
  {
    FocusVisualKind FocusVisualKind { get; set; }

    ApplicationRequiresPointerMode RequiresPointerMode { get; set; }

    event LeavingBackgroundEventHandler LeavingBackground;

    event EnteredBackgroundEventHandler EnteredBackground;
  }
}
