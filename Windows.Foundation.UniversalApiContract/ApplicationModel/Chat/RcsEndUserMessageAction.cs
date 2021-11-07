// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsEndUserMessageAction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents the actions to which the user can respond.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class RcsEndUserMessageAction : IRcsEndUserMessageAction
  {
    /// <summary>Gets the label of the action.</summary>
    /// <returns>The label of the action.</returns>
    public extern string Label { [MethodImpl] get; }
  }
}
