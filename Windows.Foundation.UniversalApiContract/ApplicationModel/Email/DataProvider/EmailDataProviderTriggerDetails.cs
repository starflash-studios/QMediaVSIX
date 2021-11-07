// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailDataProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Contains details about the event that triggered your email data provider background task.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailDataProviderTriggerDetails : IEmailDataProviderTriggerDetails
  {
    /// <summary>Gets the EmailDataProviderConnection to be used to communicate with an email client app.</summary>
    /// <returns>The connection your email data provider uses to communicate with an email client app. When you handler is triggered, your code should register event handlers on this connection for the email data provider events included in the EmailDataProviderConnection class.</returns>
    public extern EmailDataProviderConnection Connection { [MethodImpl] get; }
  }
}
