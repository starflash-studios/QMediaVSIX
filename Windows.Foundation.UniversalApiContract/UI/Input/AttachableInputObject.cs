// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.AttachableInputObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Base class for an InputActivationListener object associated with a window, view, or other visual element.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Composable(typeof (IAttachableInputObjectFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class AttachableInputObject : IAttachableInputObject, IClosable
  {
    [MethodImpl]
    public extern void Close();
  }
}
