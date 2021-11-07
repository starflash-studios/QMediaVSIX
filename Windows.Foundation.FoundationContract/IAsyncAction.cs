// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncAction
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents an asynchronous action. This is the return type for many Windows Runtime asynchronous methods that don't have a result object, and don't report ongoing progress.</summary>
  [Guid(1516535814, 33850, 19881, 134, 91, 157, 38, 229, 223, 173, 123)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncAction : IAsyncInfo
  {
    /// <summary>Gets or sets the method that handles the action completed notification.</summary>
    /// <returns>The method that handles the notification.</returns>
    AsyncActionCompletedHandler Completed { set; get; }

    /// <summary>Returns the results of the action.</summary>
    void GetResults();
  }
}
