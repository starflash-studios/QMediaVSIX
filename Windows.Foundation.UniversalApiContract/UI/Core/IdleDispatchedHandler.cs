// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IdleDispatchedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Represents the method that handles CoreWindow idle priority dispatch events. It is invoked when CoreDispatcher.RunIdleAsync is called.</summary>
  /// <param name="e">The set of arguments returned by the callback.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2754284580, 32545, 19132, 153, 193, 143, 1, 0, 127, 8, 128)]
  [WebHostHidden]
  public delegate void IdleDispatchedHandler(IdleDispatchedHandlerArgs e);
}
