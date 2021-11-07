// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncActionCompletedHandler
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a method that handles the completed event of an asynchronous action.</summary>
  /// <param name="asyncInfo">The asynchronous action.</param>
  /// <param name="asyncStatus">One of the enumeration values.</param>
  [Guid(2767019137, 30409, 16573, 139, 230, 177, 217, 15, 178, 10, 231)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncActionCompletedHandler(IAsyncAction asyncInfo, AsyncStatus asyncStatus);
}
