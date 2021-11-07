// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ITransformPattern2IdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2023110212, 4592, 18044, 167, 43, 93, 172, 65, 193, 246, 254)]
  [ExclusiveTo(typeof (TransformPattern2Identifiers))]
  internal interface ITransformPattern2IdentifiersStatics
  {
    AutomationProperty CanZoomProperty { get; }

    AutomationProperty ZoomLevelProperty { get; }

    AutomationProperty MaxZoomProperty { get; }

    AutomationProperty MinZoomProperty { get; }
  }
}
