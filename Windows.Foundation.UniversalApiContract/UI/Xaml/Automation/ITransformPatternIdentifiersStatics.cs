// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ITransformPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1165028779, 55045, 16580, 161, 220, 233, 172, 252, 239, 133, 246)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TransformPatternIdentifiers))]
  internal interface ITransformPatternIdentifiersStatics
  {
    AutomationProperty CanMoveProperty { get; }

    AutomationProperty CanResizeProperty { get; }

    AutomationProperty CanRotateProperty { get; }
  }
}
