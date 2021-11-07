// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySoapMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadySoapMessage))]
  [Guid(3059350709, 52801, 16826, 138, 13, 97, 223, 95, 255, 161, 57)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadySoapMessage
  {
    byte[] GetMessageBody();

    IPropertySet MessageHeaders { get; }

    Uri Uri { get; }
  }
}
