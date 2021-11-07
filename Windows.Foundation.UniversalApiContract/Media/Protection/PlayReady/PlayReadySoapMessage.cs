// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadySoapMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Contains a SOAP message used in manual challenge requests.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadySoapMessage : IPlayReadySoapMessage
  {
    /// <summary>Retrieves the contents of the SOAP message.</summary>
    /// <returns>The contents of the SOAP message.</returns>
    [MethodImpl]
    public extern byte[] GetMessageBody();

    /// <summary>Gets a collection of the SOAP headers applied to the current SOAP request or SOAP response.</summary>
    /// <returns>The SOAP message headers.</returns>
    public extern IPropertySet MessageHeaders { [MethodImpl] get; }

    /// <summary>Gets the base URL of the XML Web service.</summary>
    /// <returns>The base URL of the XML Web service.</returns>
    public extern Uri Uri { [MethodImpl] get; }
  }
}
