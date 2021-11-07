// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreIndependentInputSourceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Core
{
  [Static(typeof (ICoreIndependentInputSourceControllerStatics), 851968, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class CoreIndependentInputSourceController : 
    ICoreIndependentInputSourceController,
    IClosable
  {
    public extern bool IsTransparentForUncontrolledInput { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPalmRejectionEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern CoreIndependentInputSource Source { [MethodImpl] get; }

    [Overload("SetControlledInput")]
    [MethodImpl]
    public extern void SetControlledInput(CoreInputDeviceTypes inputTypes);

    [Overload("SetControlledInputWithFilters")]
    [MethodImpl]
    public extern void SetControlledInput(
      CoreInputDeviceTypes inputTypes,
      CoreIndependentInputFilters required,
      CoreIndependentInputFilters excluded);

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public static extern CoreIndependentInputSourceController CreateForVisual(
      Visual visual);

    [MethodImpl]
    public static extern CoreIndependentInputSourceController CreateForIVisualElement(
      IVisualElement visualElement);
  }
}
