// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsEncodedLength
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>This structure represents information about the length of an SmsTextMessage object when it is encoded as a PDU.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct SmsEncodedLength
  {
    /// <summary>The number of segments needed to encode the message.</summary>
    public uint SegmentCount;
    /// <summary>The number of characters in the last segment of the encoded message.</summary>
    public uint CharacterCountLastSegment;
    /// <summary>The estimated number of characters that can fit in one segment of the message.</summary>
    public uint CharactersPerSegment;
    /// <summary>The number of bytes in the last segment of the encoded message.</summary>
    public uint ByteCountLastSegment;
    /// <summary>The number of bytes in each segment of the message.</summary>
    public uint BytesPerSegment;
  }
}
