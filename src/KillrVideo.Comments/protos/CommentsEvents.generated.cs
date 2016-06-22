// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: comments/comments_events.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace KillrVideo.Comments.Events {

  /// <summary>Holder for reflection information generated from comments/comments_events.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CommentsEventsReflection {

    #region Descriptor
    /// <summary>File descriptor for comments/comments_events.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommentsEventsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5jb21tZW50cy9jb21tZW50c19ldmVudHMucHJvdG8SGmtpbGxydmlkZW8u",
            "Y29tbWVudHMuZXZlbnRzGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnBy",
            "b3RvGhljb21tb24vY29tbW9uX3R5cGVzLnByb3RvItMBChRVc2VyQ29tbWVu",
            "dGVkT25WaWRlbxIoCgd1c2VyX2lkGAEgASgLMhcua2lsbHJ2aWRlby5jb21t",
            "b24uVXVpZBIpCgh2aWRlb19pZBgCIAEoCzIXLmtpbGxydmlkZW8uY29tbW9u",
            "LlV1aWQSLwoKY29tbWVudF9pZBgDIAEoCzIbLmtpbGxydmlkZW8uY29tbW9u",
            "LlRpbWVVdWlkEjUKEWNvbW1lbnRfdGltZXN0YW1wGAQgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcEIdqgIaS2lsbHJWaWRlby5Db21tZW50cy5F",
            "dmVudHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::KillrVideo.Protobuf.CommonTypesReflection.Descriptor, },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Comments.Events.UserCommentedOnVideo), global::KillrVideo.Comments.Events.UserCommentedOnVideo.Parser, new[]{ "UserId", "VideoId", "CommentId", "CommentTimestamp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Message published when a user commented on a video
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UserCommentedOnVideo : pb::IMessage<UserCommentedOnVideo> {
    private static readonly pb::MessageParser<UserCommentedOnVideo> _parser = new pb::MessageParser<UserCommentedOnVideo>(() => new UserCommentedOnVideo());
    public static pb::MessageParser<UserCommentedOnVideo> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Comments.Events.CommentsEventsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UserCommentedOnVideo() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UserCommentedOnVideo(UserCommentedOnVideo other) : this() {
      UserId = other.userId_ != null ? other.UserId.Clone() : null;
      VideoId = other.videoId_ != null ? other.VideoId.Clone() : null;
      CommentId = other.commentId_ != null ? other.CommentId.Clone() : null;
      CommentTimestamp = other.commentTimestamp_ != null ? other.CommentTimestamp.Clone() : null;
    }

    public UserCommentedOnVideo Clone() {
      return new UserCommentedOnVideo(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private global::KillrVideo.Protobuf.Uuid userId_;
    public global::KillrVideo.Protobuf.Uuid UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "video_id" field.</summary>
    public const int VideoIdFieldNumber = 2;
    private global::KillrVideo.Protobuf.Uuid videoId_;
    public global::KillrVideo.Protobuf.Uuid VideoId {
      get { return videoId_; }
      set {
        videoId_ = value;
      }
    }

    /// <summary>Field number for the "comment_id" field.</summary>
    public const int CommentIdFieldNumber = 3;
    private global::KillrVideo.Protobuf.TimeUuid commentId_;
    public global::KillrVideo.Protobuf.TimeUuid CommentId {
      get { return commentId_; }
      set {
        commentId_ = value;
      }
    }

    /// <summary>Field number for the "comment_timestamp" field.</summary>
    public const int CommentTimestampFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp commentTimestamp_;
    public global::Google.Protobuf.WellKnownTypes.Timestamp CommentTimestamp {
      get { return commentTimestamp_; }
      set {
        commentTimestamp_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UserCommentedOnVideo);
    }

    public bool Equals(UserCommentedOnVideo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UserId, other.UserId)) return false;
      if (!object.Equals(VideoId, other.VideoId)) return false;
      if (!object.Equals(CommentId, other.CommentId)) return false;
      if (!object.Equals(CommentTimestamp, other.CommentTimestamp)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (userId_ != null) hash ^= UserId.GetHashCode();
      if (videoId_ != null) hash ^= VideoId.GetHashCode();
      if (commentId_ != null) hash ^= CommentId.GetHashCode();
      if (commentTimestamp_ != null) hash ^= CommentTimestamp.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (userId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserId);
      }
      if (videoId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(VideoId);
      }
      if (commentId_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CommentId);
      }
      if (commentTimestamp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CommentTimestamp);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (userId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserId);
      }
      if (videoId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VideoId);
      }
      if (commentId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommentId);
      }
      if (commentTimestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommentTimestamp);
      }
      return size;
    }

    public void MergeFrom(UserCommentedOnVideo other) {
      if (other == null) {
        return;
      }
      if (other.userId_ != null) {
        if (userId_ == null) {
          userId_ = new global::KillrVideo.Protobuf.Uuid();
        }
        UserId.MergeFrom(other.UserId);
      }
      if (other.videoId_ != null) {
        if (videoId_ == null) {
          videoId_ = new global::KillrVideo.Protobuf.Uuid();
        }
        VideoId.MergeFrom(other.VideoId);
      }
      if (other.commentId_ != null) {
        if (commentId_ == null) {
          commentId_ = new global::KillrVideo.Protobuf.TimeUuid();
        }
        CommentId.MergeFrom(other.CommentId);
      }
      if (other.commentTimestamp_ != null) {
        if (commentTimestamp_ == null) {
          commentTimestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CommentTimestamp.MergeFrom(other.CommentTimestamp);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (userId_ == null) {
              userId_ = new global::KillrVideo.Protobuf.Uuid();
            }
            input.ReadMessage(userId_);
            break;
          }
          case 18: {
            if (videoId_ == null) {
              videoId_ = new global::KillrVideo.Protobuf.Uuid();
            }
            input.ReadMessage(videoId_);
            break;
          }
          case 26: {
            if (commentId_ == null) {
              commentId_ = new global::KillrVideo.Protobuf.TimeUuid();
            }
            input.ReadMessage(commentId_);
            break;
          }
          case 34: {
            if (commentTimestamp_ == null) {
              commentTimestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(commentTimestamp_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
