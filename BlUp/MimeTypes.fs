namespace BlUp

module MimeTypes =
    
    let mimeTypes =
        Map.empty
        |> Map.add "323" "text/h323"
        |> Map.add "3g2" "video/3gpp2"
        |> Map.add "3gp" "video/3gpp"
        |> Map.add "3gp2" "video/3gpp2"
        |> Map.add "3gpp" "video/3gpp"
        |> Map.add "7z" "application/x-7z-compressed"
        |> Map.add "aa" "audio/audible"
        |> Map.add "AAC" "audio/aac"
        |> Map.add "aaf" "application/octet-stream"
        |> Map.add "aax" "audio/vnd.audible.aax"
        |> Map.add "ac3" "audio/ac3"
        |> Map.add "aca" "application/octet-stream"
        |> Map.add "accda" "application/msaccess.addin"
        |> Map.add "accdb" "application/msaccess"
        |> Map.add "accdc" "application/msaccess.cab"
        |> Map.add "accde" "application/msaccess"
        |> Map.add "accdr" "application/msaccess.runtime"
        |> Map.add "accdt" "application/msaccess"
        |> Map.add "accdw" "application/msaccess.webapplication"
        |> Map.add "accft" "application/msaccess.ftemplate"
        |> Map.add "acx" "application/internet-property-stream"
        |> Map.add "AddIn" "text/xml"
        |> Map.add "ade" "application/msaccess"
        |> Map.add "adobebridge" "application/x-bridge-url"
        |> Map.add "adp" "application/msaccess"
        |> Map.add "ADT" "audio/vnd.dlna.adts"
        |> Map.add "ADTS" "audio/aac"
        |> Map.add "afm" "application/octet-stream"
        |> Map.add "ai" "application/postscript"
        |> Map.add "aif" "audio/aiff"
        |> Map.add "aifc" "audio/aiff"
        |> Map.add "aiff" "audio/aiff"
        |> Map.add "air" "application/vnd.adobe.air-application-installer-package+zip"
        |> Map.add "amc" "application/mpeg"
        |> Map.add "anx" "application/annodex"
        |> Map.add "apk" "application/vnd.android.package-archive"
        |> Map.add "apng" "image/apng"
        |> Map.add "application" "application/x-ms-application"
        |> Map.add "art" "image/x-jg"
        |> Map.add "asa" "application/xml"
        |> Map.add "asax" "application/xml"
        |> Map.add "ascx" "application/xml"
        |> Map.add "asd" "application/octet-stream"
        |> Map.add "asf" "video/x-ms-asf"
        |> Map.add "ashx" "application/xml"
        |> Map.add "asi" "application/octet-stream"
        |> Map.add "asm" "text/plain"
        |> Map.add "asmx" "application/xml"
        |> Map.add "aspx" "application/xml"
        |> Map.add "asr" "video/x-ms-asf"
        |> Map.add "asx" "video/x-ms-asf"
        |> Map.add "atom" "application/atom+xml"
        |> Map.add "au" "audio/basic"
        |> Map.add "avci" "image/avci"
        |> Map.add "avcs" "image/avcs"
        |> Map.add "avi" "video/x-msvideo"
        |> Map.add "avif" "image/avif"
        |> Map.add "avifs" "image/avif-sequence"
        |> Map.add "axa" "audio/annodex"
        |> Map.add "axs" "application/olescript"
        |> Map.add "axv" "video/annodex"
        |> Map.add "bas" "text/plain"
        |> Map.add "bcpio" "application/x-bcpio"
        |> Map.add "bin" "application/octet-stream"
        |> Map.add "bmp" "image/bmp"
        |> Map.add "c" "text/plain"
        |> Map.add "cab" "application/octet-stream"
        |> Map.add "caf" "audio/x-caf"
        |> Map.add "calx" "application/vnd.ms-office.calx"
        |> Map.add "cat" "application/vnd.ms-pki.seccat"
        |> Map.add "cc" "text/plain"
        |> Map.add "cd" "text/plain"
        |> Map.add "cdda" "audio/aiff"
        |> Map.add "cdf" "application/x-cdf"
        |> Map.add "cer" "application/x-x509-ca-cert"
        |> Map.add "cfg" "text/plain"
        |> Map.add "chm" "application/octet-stream"
        |> Map.add "class" "application/x-java-applet"
        |> Map.add "clp" "application/x-msclip"
        |> Map.add "cmd" "text/plain"
        |> Map.add "cmx" "image/x-cmx"
        |> Map.add "cnf" "text/plain"
        |> Map.add "cod" "image/cis-cod"
        |> Map.add "config" "application/xml"
        |> Map.add "contact" "text/x-ms-contact"
        |> Map.add "coverage" "application/xml"
        |> Map.add "cpio" "application/x-cpio"
        |> Map.add "cpp" "text/plain"
        |> Map.add "crd" "application/x-mscardfile"
        |> Map.add "crl" "application/pkix-crl"
        |> Map.add "crt" "application/x-x509-ca-cert"
        |> Map.add "cs" "text/plain"
        |> Map.add "csdproj" "text/plain"
        |> Map.add "csh" "application/x-csh"
        |> Map.add "csproj" "text/plain"
        |> Map.add "css" "text/css"
        |> Map.add "csv" "text/csv"
        |> Map.add "cur" "application/octet-stream"
        |> Map.add "czx" "application/x-czx"
        |> Map.add "cxx" "text/plain"
        |> Map.add "dat" "application/octet-stream"
        |> Map.add "datasource" "application/xml"
        |> Map.add "dbproj" "text/plain"
        |> Map.add "dcr" "application/x-director"
        |> Map.add "def" "text/plain"
        |> Map.add "deploy" "application/octet-stream"
        |> Map.add "der" "application/x-x509-ca-cert"
        |> Map.add "dgml" "application/xml"
        |> Map.add "dib" "image/bmp"
        |> Map.add "dif" "video/x-dv"
        |> Map.add "dir" "application/x-director"
        |> Map.add "disco" "text/xml"
        |> Map.add "divx" "video/divx"
        |> Map.add "dll" "application/x-msdownload"
        |> Map.add "dlm" "text/dlm"
        |> Map.add "doc" "application/msword"
        |> Map.add "docm" "application/vnd.ms-word.document.macroEnabled.12"
        |> Map.add "docx" "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        |> Map.add "dot" "application/msword"
        |> Map.add "dotm" "application/vnd.ms-word.template.macroEnabled.12"
        |> Map.add "dotx" "application/vnd.openxmlformats-officedocument.wordprocessingml.template"
        |> Map.add "dsp" "application/octet-stream"
        |> Map.add "dsw" "text/plain"
        |> Map.add "dtd" "text/xml"
        |> Map.add "dtsConfig" "text/xml"
        |> Map.add "dv" "video/x-dv"
        |> Map.add "dvi" "application/x-dvi"
        |> Map.add "dwf" "drawing/x-dwf"
        |> Map.add "dwg" "application/acad"
        |> Map.add "dwp" "application/octet-stream"
        |> Map.add "dxf" "application/x-dxf"
        |> Map.add "dxr" "application/x-director"
        |> Map.add "eml" "message/rfc822"
        |> Map.add "emf" "image/emf"
        |> Map.add "emz" "application/octet-stream"
        |> Map.add "eot" "application/vnd.ms-fontobject"
        |> Map.add "eps" "application/postscript"
        |> Map.add "es" "application/ecmascript"
        |> Map.add "etl" "application/etl"
        |> Map.add "etx" "text/x-setext"
        |> Map.add "evy" "application/envoy"
        |> Map.add "exe" "application/vnd.microsoft.portable-executable"
        |> Map.add "f4v" "video/mp4"
        |> Map.add "fdf" "application/vnd.fdf"
        |> Map.add "fif" "application/fractals"
        |> Map.add "filters" "application/xml"
        |> Map.add "fla" "application/octet-stream"
        |> Map.add "flac" "audio/flac"
        |> Map.add "flr" "x-world/x-vrml"
        |> Map.add "flv" "video/x-flv"
        |> Map.add "fsscript" "application/fsharp-script"
        |> Map.add "fsx" "application/fsharp-script"
        |> Map.add "generictest" "application/xml"
        |> Map.add "geojson" "application/geo+json"
        |> Map.add "gif" "image/gif"
        |> Map.add "gpx" "application/gpx+xml"
        |> Map.add "group" "text/x-ms-group"
        |> Map.add "gsm" "audio/x-gsm"
        |> Map.add "gtar" "application/x-gtar"
        |> Map.add "gz" "application/x-gzip"
        |> Map.add "h" "text/plain"
        |> Map.add "hdf" "application/x-hdf"
        |> Map.add "hdml" "text/x-hdml"
        |> Map.add "heic" "image/heic"
        |> Map.add "heics" "image/heic-sequence"
        |> Map.add "heif" "image/heif"
        |> Map.add "heifs" "image/heif-sequence"
        |> Map.add "hhc" "application/x-oleobject"
        |> Map.add "hhk" "application/octet-stream"
        |> Map.add "hhp" "application/octet-stream"
        |> Map.add "hlp" "application/winhlp"
        |> Map.add "hpp" "text/plain"
        |> Map.add "hqx" "application/mac-binhex40"
        |> Map.add "hta" "application/hta"
        |> Map.add "htc" "text/x-component"
        |> Map.add "htm" "text/html"
        |> Map.add "html" "text/html"
        |> Map.add "htt" "text/webviewhtml"
        |> Map.add "hxa" "application/xml"
        |> Map.add "hxc" "application/xml"
        |> Map.add "hxd" "application/octet-stream"
        |> Map.add "hxe" "application/xml"
        |> Map.add "hxf" "application/xml"
        |> Map.add "hxh" "application/octet-stream"
        |> Map.add "hxi" "application/octet-stream"
        |> Map.add "hxk" "application/xml"
        |> Map.add "hxq" "application/octet-stream"
        |> Map.add "hxr" "application/octet-stream"
        |> Map.add "hxs" "application/octet-stream"
        |> Map.add "hxt" "text/html"
        |> Map.add "hxv" "application/xml"
        |> Map.add "hxw" "application/octet-stream"
        |> Map.add "hxx" "text/plain"
        |> Map.add "i" "text/plain"
        |> Map.add "ical" "text/calendar"
        |> Map.add "icalendar" "text/calendar"
        |> Map.add "ico" "image/x-icon"
        |> Map.add "ics" "text/calendar"
        |> Map.add "idl" "text/plain"
        |> Map.add "ief" "image/ief"
        |> Map.add "ifb" "text/calendar"
        |> Map.add "iii" "application/x-iphone"
        |> Map.add "inc" "text/plain"
        |> Map.add "inf" "application/octet-stream"
        |> Map.add "ini" "text/plain"
        |> Map.add "inl" "text/plain"
        |> Map.add "ins" "application/x-internet-signup"
        |> Map.add "ipa" "application/x-itunes-ipa"
        |> Map.add "ipg" "application/x-itunes-ipg"
        |> Map.add "ipproj" "text/plain"
        |> Map.add "ipsw" "application/x-itunes-ipsw"
        |> Map.add "iqy" "text/x-ms-iqy"
        |> Map.add "isp" "application/x-internet-signup"
        |> Map.add "isma" "application/octet-stream"
        |> Map.add "ismv" "application/octet-stream"
        |> Map.add "ite" "application/x-itunes-ite"
        |> Map.add "itlp" "application/x-itunes-itlp"
        |> Map.add "itms" "application/x-itunes-itms"
        |> Map.add "itpc" "application/x-itunes-itpc"
        |> Map.add "IVF" "video/x-ivf"
        |> Map.add "jar" "application/java-archive"
        |> Map.add "java" "application/octet-stream"
        |> Map.add "jck" "application/liquidmotion"
        |> Map.add "jcz" "application/liquidmotion"
        |> Map.add "jfif" "image/pjpeg"
        |> Map.add "jnlp" "application/x-java-jnlp-file"
        |> Map.add "jpb" "application/octet-stream"
        |> Map.add "jpe" "image/jpeg"
        |> Map.add "jpeg" "image/jpeg"
        |> Map.add "jpg" "image/jpeg"
        |> Map.add "js" "application/javascript"
        |> Map.add "json" "application/json"
        |> Map.add "jsx" "text/jscript"
        |> Map.add "jsxbin" "text/plain"
        |> Map.add "key" "application/vnd.apple.keynote"
        |> Map.add "latex" "application/x-latex"
        |> Map.add "library-s" "application/windows-library+xml"
        |> Map.add "lit" "application/x-ms-reader"
        |> Map.add "loadtest" "application/xml"
        |> Map.add "lpk" "application/octet-stream"
        |> Map.add "lsf" "video/x-la-asf"
        |> Map.add "lst" "text/plain"
        |> Map.add "lsx" "video/x-la-asf"
        |> Map.add "lzh" "application/octet-stream"
        |> Map.add "m13" "application/x-msmediaview"
        |> Map.add "m14" "application/x-msmediaview"
        |> Map.add "m1v" "video/mpeg"
        |> Map.add "m2t" "video/vnd.dlna.mpeg-tts"
        |> Map.add "m2ts" "video/vnd.dlna.mpeg-tts"
        |> Map.add "m2v" "video/mpeg"
        |> Map.add "m3u" "audio/x-mpegurl"
        |> Map.add "m3u8" "audio/x-mpegurl"
        |> Map.add "m4a" "audio/m4a"
        |> Map.add "m4b" "audio/m4b"
        |> Map.add "m4p" "audio/m4p"
        |> Map.add "m4r" "audio/x-m4r"
        |> Map.add "m4v" "video/x-m4v"
        |> Map.add "mac" "image/x-macpaint"
        |> Map.add "mak" "text/plain"
        |> Map.add "man" "application/x-troff-man"
        |> Map.add "manifest" "application/x-ms-manifest"
        |> Map.add "map" "text/plain"
        |> Map.add "master" "application/xml"
        |> Map.add "mbox" "application/mbox"
        |> Map.add "mda" "application/msaccess"
        |> Map.add "mdb" "application/x-msaccess"
        |> Map.add "mde" "application/msaccess"
        |> Map.add "mdp" "application/octet-stream"
        |> Map.add "me" "application/x-troff-me"
        |> Map.add "mfp" "application/x-shockwave-flash"
        |> Map.add "mht" "message/rfc822"
        |> Map.add "mhtml" "message/rfc822"
        |> Map.add "mid" "audio/mid"
        |> Map.add "midi" "audio/mid"
        |> Map.add "mix" "application/octet-stream"
        |> Map.add "mk" "text/plain"
        |> Map.add "mk3d" "video/x-matroska-3d"
        |> Map.add "mka" "audio/x-matroska"
        |> Map.add "mkv" "video/x-matroska"
        |> Map.add "mmf" "application/x-smaf"
        |> Map.add "mno" "text/xml"
        |> Map.add "mny" "application/x-msmoney"
        |> Map.add "mod" "video/mpeg"
        |> Map.add "mov" "video/quicktime"
        |> Map.add "movie" "video/x-sgi-movie"
        |> Map.add "mp2" "video/mpeg"
        |> Map.add "mp2v" "video/mpeg"
        |> Map.add "mp3" "audio/mpeg"
        |> Map.add "mp4" "video/mp4"
        |> Map.add "mp4v" "video/mp4"
        |> Map.add "mpa" "video/mpeg"
        |> Map.add "mpe" "video/mpeg"
        |> Map.add "mpeg" "video/mpeg"
        |> Map.add "mpf" "application/vnd.ms-mediapackage"
        |> Map.add "mpg" "video/mpeg"
        |> Map.add "mpp" "application/vnd.ms-project"
        |> Map.add "mpv2" "video/mpeg"
        |> Map.add "mqv" "video/quicktime"
        |> Map.add "ms" "application/x-troff-ms"
        |> Map.add "msg" "application/vnd.ms-outlook"
        |> Map.add "msi" "application/octet-stream"
        |> Map.add "mso" "application/octet-stream"
        |> Map.add "mts" "video/vnd.dlna.mpeg-tts"
        |> Map.add "mtx" "application/xml"
        |> Map.add "mvb" "application/x-msmediaview"
        |> Map.add "mvc" "application/x-miva-compiled"
        |> Map.add "mxf" "application/mxf"
        |> Map.add "mxp" "application/x-mmxp"
        |> Map.add "nc" "application/x-netcdf"
        |> Map.add "nsc" "video/x-ms-asf"
        |> Map.add "numbers" "application/vnd.apple.numbers"
        |> Map.add "nws" "message/rfc822"
        |> Map.add "ocx" "application/octet-stream"
        |> Map.add "oda" "application/oda"
        |> Map.add "odb" "application/vnd.oasis.opendocument.database"
        |> Map.add "odc" "application/vnd.oasis.opendocument.chart"
        |> Map.add "odf" "application/vnd.oasis.opendocument.formula"
        |> Map.add "odg" "application/vnd.oasis.opendocument.graphics"
        |> Map.add "odh" "text/plain"
        |> Map.add "odi" "application/vnd.oasis.opendocument.image"
        |> Map.add "odl" "text/plain"
        |> Map.add "odm" "application/vnd.oasis.opendocument.text-master"
        |> Map.add "odp" "application/vnd.oasis.opendocument.presentation"
        |> Map.add "ods" "application/vnd.oasis.opendocument.spreadsheet"
        |> Map.add "odt" "application/vnd.oasis.opendocument.text"
        |> Map.add "oga" "audio/ogg"
        |> Map.add "ogg" "audio/ogg"
        |> Map.add "ogv" "video/ogg"
        |> Map.add "ogx" "application/ogg"
        |> Map.add "one" "application/onenote"
        |> Map.add "onea" "application/onenote"
        |> Map.add "onepkg" "application/onenote"
        |> Map.add "onetmp" "application/onenote"
        |> Map.add "onetoc" "application/onenote"
        |> Map.add "onetoc2" "application/onenote"
        |> Map.add "opus" "audio/ogg"
        |> Map.add "orderedtest" "application/xml"
        |> Map.add "osdx" "application/opensearchdescription+xml"
        |> Map.add "otf" "application/font-sfnt"
        |> Map.add "otg" "application/vnd.oasis.opendocument.graphics-template"
        |> Map.add "oth" "application/vnd.oasis.opendocument.text-web"
        |> Map.add "otp" "application/vnd.oasis.opendocument.presentation-template"
        |> Map.add "ots" "application/vnd.oasis.opendocument.spreadsheet-template"
        |> Map.add "ott" "application/vnd.oasis.opendocument.text-template"
        |> Map.add "oxps" "application/oxps"
        |> Map.add "oxt" "application/vnd.openofficeorg.extension"
        |> Map.add "p10" "application/pkcs10"
        |> Map.add "p12" "application/x-pkcs12"
        |> Map.add "p7b" "application/x-pkcs7-certificates"
        |> Map.add "p7c" "application/pkcs7-mime"
        |> Map.add "p7m" "application/pkcs7-mime"
        |> Map.add "p7r" "application/x-pkcs7-certreqresp"
        |> Map.add "p7s" "application/pkcs7-signature"
        |> Map.add "pages" "application/vnd.apple.pages"
        |> Map.add "pbm" "image/x-portable-bitmap"
        |> Map.add "pcast" "application/x-podcast"
        |> Map.add "pct" "image/pict"
        |> Map.add "pcx" "application/octet-stream"
        |> Map.add "pcz" "application/octet-stream"
        |> Map.add "pdf" "application/pdf"
        |> Map.add "pfb" "application/octet-stream"
        |> Map.add "pfm" "application/octet-stream"
        |> Map.add "pfx" "application/x-pkcs12"
        |> Map.add "pgm" "image/x-portable-graymap"
        |> Map.add "pic" "image/pict"
        |> Map.add "pict" "image/pict"
        |> Map.add "pkgdef" "text/plain"
        |> Map.add "pkgundef" "text/plain"
        |> Map.add "pko" "application/vnd.ms-pki.pko"
        |> Map.add "pls" "audio/scpls"
        |> Map.add "pma" "application/x-perfmon"
        |> Map.add "pmc" "application/x-perfmon"
        |> Map.add "pml" "application/x-perfmon"
        |> Map.add "pmr" "application/x-perfmon"
        |> Map.add "pmw" "application/x-perfmon"
        |> Map.add "png" "image/png"
        |> Map.add "pnm" "image/x-portable-anymap"
        |> Map.add "pnt" "image/x-macpaint"
        |> Map.add "pntg" "image/x-macpaint"
        |> Map.add "pnz" "image/png"
        |> Map.add "pot" "application/vnd.ms-powerpoint"
        |> Map.add "potm" "application/vnd.ms-powerpoint.template.macroEnabled.12"
        |> Map.add "potx" "application/vnd.openxmlformats-officedocument.presentationml.template"
        |> Map.add "ppa" "application/vnd.ms-powerpoint"
        |> Map.add "ppam" "application/vnd.ms-powerpoint.addin.macroEnabled.12"
        |> Map.add "ppm" "image/x-portable-pixmap"
        |> Map.add "pps" "application/vnd.ms-powerpoint"
        |> Map.add "ppsm" "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"
        |> Map.add "ppsx" "application/vnd.openxmlformats-officedocument.presentationml.slideshow"
        |> Map.add "ppt" "application/vnd.ms-powerpoint"
        |> Map.add "pptm" "application/vnd.ms-powerpoint.presentation.macroEnabled.12"
        |> Map.add "pptx" "application/vnd.openxmlformats-officedocument.presentationml.presentation"
        |> Map.add "prf" "application/pics-rules"
        |> Map.add "prm" "application/octet-stream"
        |> Map.add "prx" "application/octet-stream"
        |> Map.add "ps" "application/postscript"
        |> Map.add "psc1" "application/PowerShell"
        |> Map.add "psd" "application/octet-stream"
        |> Map.add "psess" "application/xml"
        |> Map.add "psm" "application/octet-stream"
        |> Map.add "psp" "application/octet-stream"
        |> Map.add "pst" "application/vnd.ms-outlook"
        |> Map.add "pub" "application/x-mspublisher"
        |> Map.add "pwz" "application/vnd.ms-powerpoint"
        |> Map.add "qht" "text/x-html-insertion"
        |> Map.add "qhtm" "text/x-html-insertion"
        |> Map.add "qt" "video/quicktime"
        |> Map.add "qti" "image/x-quicktime"
        |> Map.add "qtif" "image/x-quicktime"
        |> Map.add "qtl" "application/x-quicktimeplayer"
        |> Map.add "qxd" "application/octet-stream"
        |> Map.add "ra" "audio/x-pn-realaudio"
        |> Map.add "ram" "audio/x-pn-realaudio"
        |> Map.add "rar" "application/x-rar-compressed"
        |> Map.add "ras" "image/x-cmu-raster"
        |> Map.add "rat" "application/rat-file"
        |> Map.add "rc" "text/plain"
        |> Map.add "rc2" "text/plain"
        |> Map.add "rct" "text/plain"
        |> Map.add "rdlc" "application/xml"
        |> Map.add "reg" "text/plain"
        |> Map.add "resx" "application/xml"
        |> Map.add "rf" "image/vnd.rn-realflash"
        |> Map.add "rgb" "image/x-rgb"
        |> Map.add "rgs" "text/plain"
        |> Map.add "rm" "application/vnd.rn-realmedia"
        |> Map.add "rmi" "audio/mid"
        |> Map.add "rmp" "application/vnd.rn-rn_music_package"
        |> Map.add "rmvb" "application/vnd.rn-realmedia-vbr"
        |> Map.add "roff" "application/x-troff"
        |> Map.add "rpm" "audio/x-pn-realaudio-plugin"
        |> Map.add "rqy" "text/x-ms-rqy"
        |> Map.add "rtf" "application/rtf"
        |> Map.add "rtx" "text/richtext"
        |> Map.add "rvt" "application/octet-stream"
        |> Map.add "ruleset" "application/xml"
        |> Map.add "s" "text/plain"
        |> Map.add "safariextz" "application/x-safari-safariextz"
        |> Map.add "scd" "application/x-msschedule"
        |> Map.add "scr" "text/plain"
        |> Map.add "sct" "text/scriptlet"
        |> Map.add "sd2" "audio/x-sd2"
        |> Map.add "sdp" "application/sdp"
        |> Map.add "sea" "application/octet-stream"
        |> Map.add "searchConnector-s" "application/windows-search-connector+xml"
        |> Map.add "setpay" "application/set-payment-initiation"
        |> Map.add "setreg" "application/set-registration-initiation"
        |> Map.add "settings" "application/xml"
        |> Map.add "sgimb" "application/x-sgimb"
        |> Map.add "sgml" "text/sgml"
        |> Map.add "sh" "application/x-sh"
        |> Map.add "shar" "application/x-shar"
        |> Map.add "shtml" "text/html"
        |> Map.add "sit" "application/x-stuffit"
        |> Map.add "sitemap" "application/xml"
        |> Map.add "skin" "application/xml"
        |> Map.add "skp" "application/x-koan"
        |> Map.add "sldm" "application/vnd.ms-powerpoint.slide.macroEnabled.12"
        |> Map.add "sldx" "application/vnd.openxmlformats-officedocument.presentationml.slide"
        |> Map.add "slk" "application/vnd.ms-excel"
        |> Map.add "sln" "text/plain"
        |> Map.add "slupkg-s" "application/x-ms-license"
        |> Map.add "smd" "audio/x-smd"
        |> Map.add "smi" "application/octet-stream"
        |> Map.add "smx" "audio/x-smd"
        |> Map.add "smz" "audio/x-smd"
        |> Map.add "snd" "audio/basic"
        |> Map.add "snippet" "application/xml"
        |> Map.add "snp" "application/octet-stream"
        |> Map.add "sql" "application/sql"
        |> Map.add "sol" "text/plain"
        |> Map.add "sor" "text/plain"
        |> Map.add "spc" "application/x-pkcs7-certificates"
        |> Map.add "spl" "application/futuresplash"
        |> Map.add "spx" "audio/ogg"
        |> Map.add "src" "application/x-wais-source"
        |> Map.add "srf" "text/plain"
        |> Map.add "SSISDeploymentManifest" "text/xml"
        |> Map.add "ssm" "application/streamingmedia"
        |> Map.add "sst" "application/vnd.ms-pki.certstore"
        |> Map.add "stl" "application/vnd.ms-pki.stl"
        |> Map.add "sv4cpio" "application/x-sv4cpio"
        |> Map.add "sv4crc" "application/x-sv4crc"
        |> Map.add "svc" "application/xml"
        |> Map.add "svg" "image/svg+xml"
        |> Map.add "swf" "application/x-shockwave-flash"
        |> Map.add "step" "application/step"
        |> Map.add "stp" "application/step"
        |> Map.add "t" "application/x-troff"
        |> Map.add "tar" "application/x-tar"
        |> Map.add "tcl" "application/x-tcl"
        |> Map.add "testrunconfig" "application/xml"
        |> Map.add "testsettings" "application/xml"
        |> Map.add "tex" "application/x-tex"
        |> Map.add "texi" "application/x-texinfo"
        |> Map.add "texinfo" "application/x-texinfo"
        |> Map.add "tgz" "application/x-compressed"
        |> Map.add "thmx" "application/vnd.ms-officetheme"
        |> Map.add "thn" "application/octet-stream"
        |> Map.add "tif" "image/tiff"
        |> Map.add "tiff" "image/tiff"
        |> Map.add "tlh" "text/plain"
        |> Map.add "tli" "text/plain"
        |> Map.add "toc" "application/octet-stream"
        |> Map.add "tr" "application/x-troff"
        |> Map.add "trm" "application/x-msterminal"
        |> Map.add "trx" "application/xml"
        |> Map.add "ts" "video/vnd.dlna.mpeg-tts"
        |> Map.add "tsv" "text/tab-separated-values"
        |> Map.add "ttf" "application/font-sfnt"
        |> Map.add "tts" "video/vnd.dlna.mpeg-tts"
        |> Map.add "txt" "text/plain"
        |> Map.add "u32" "application/octet-stream"
        |> Map.add "uls" "text/iuls"
        |> Map.add "user" "text/plain"
        |> Map.add "ustar" "application/x-ustar"
        |> Map.add "vb" "text/plain"
        |> Map.add "vbdproj" "text/plain"
        |> Map.add "vbk" "video/mpeg"
        |> Map.add "vbproj" "text/plain"
        |> Map.add "vbs" "text/vbscript"
        |> Map.add "vcf" "text/x-vcard"
        |> Map.add "vcproj" "application/xml"
        |> Map.add "vcs" "text/plain"
        |> Map.add "vcxproj" "application/xml"
        |> Map.add "vddproj" "text/plain"
        |> Map.add "vdp" "text/plain"
        |> Map.add "vdproj" "text/plain"
        |> Map.add "vdx" "application/vnd.ms-visio.viewer"
        |> Map.add "vml" "text/xml"
        |> Map.add "vscontent" "application/xml"
        |> Map.add "vsct" "text/xml"
        |> Map.add "vsd" "application/vnd.visio"
        |> Map.add "vsi" "application/ms-vsi"
        |> Map.add "vsix" "application/vsix"
        |> Map.add "vsixlangpack" "text/xml"
        |> Map.add "vsixmanifest" "text/xml"
        |> Map.add "vsmdi" "application/xml"
        |> Map.add "vspscc" "text/plain"
        |> Map.add "vss" "application/vnd.visio"
        |> Map.add "vsscc" "text/plain"
        |> Map.add "vssettings" "text/xml"
        |> Map.add "vssscc" "text/plain"
        |> Map.add "vst" "application/vnd.visio"
        |> Map.add "vstemplate" "text/xml"
        |> Map.add "vsto" "application/x-ms-vsto"
        |> Map.add "vsw" "application/vnd.visio"
        |> Map.add "vsx" "application/vnd.visio"
        |> Map.add "vtt" "text/vtt"
        |> Map.add "vtx" "application/vnd.visio"
        |> Map.add "wasm" "application/wasm"
        |> Map.add "wav" "audio/wav"
        |> Map.add "wave" "audio/wav"
        |> Map.add "wax" "audio/x-ms-wax"
        |> Map.add "wbk" "application/msword"
        |> Map.add "wbmp" "image/vnd.wap.wbmp"
        |> Map.add "wcm" "application/vnd.ms-works"
        |> Map.add "wdb" "application/vnd.ms-works"
        |> Map.add "wdp" "image/vnd.ms-photo"
        |> Map.add "webarchive" "application/x-safari-webarchive"
        |> Map.add "webm" "video/webm"
        |> Map.add "webp" "image/webp"
        |> Map.add "webtest" "application/xml"
        |> Map.add "wiq" "application/xml"
        |> Map.add "wiz" "application/msword"
        |> Map.add "wks" "application/vnd.ms-works"
        |> Map.add "WLMP" "application/wlmoviemaker"
        |> Map.add "wlpginstall" "application/x-wlpg-detect"
        |> Map.add "wlpginstall3" "application/x-wlpg3-detect"
        |> Map.add "wm" "video/x-ms-wm"
        |> Map.add "wma" "audio/x-ms-wma"
        |> Map.add "wmd" "application/x-ms-wmd"
        |> Map.add "wmf" "application/x-msmetafile"
        |> Map.add "wml" "text/vnd.wap.wml"
        |> Map.add "wmlc" "application/vnd.wap.wmlc"
        |> Map.add "wmls" "text/vnd.wap.wmlscript"
        |> Map.add "wmlsc" "application/vnd.wap.wmlscriptc"
        |> Map.add "wmp" "video/x-ms-wmp"
        |> Map.add "wmv" "video/x-ms-wmv"
        |> Map.add "wmx" "video/x-ms-wmx"
        |> Map.add "wmz" "application/x-ms-wmz"
        |> Map.add "woff" "application/font-woff"
        |> Map.add "woff2" "application/font-woff2"
        |> Map.add "wpl" "application/vnd.ms-wpl"
        |> Map.add "wps" "application/vnd.ms-works"
        |> Map.add "wri" "application/x-mswrite"
        |> Map.add "wrl" "x-world/x-vrml"
        |> Map.add "wrz" "x-world/x-vrml"
        |> Map.add "wsc" "text/scriptlet"
        |> Map.add "wsdl" "text/xml"
        |> Map.add "wvx" "video/x-ms-wvx"
        |> Map.add "x" "application/directx"
        |> Map.add "xaf" "x-world/x-vrml"
        |> Map.add "xaml" "application/xaml+xml"
        |> Map.add "xap" "application/x-silverlight-app"
        |> Map.add "xbap" "application/x-ms-xbap"
        |> Map.add "xbm" "image/x-xbitmap"
        |> Map.add "xdr" "text/plain"
        |> Map.add "xht" "application/xhtml+xml"
        |> Map.add "xhtml" "application/xhtml+xml"
        |> Map.add "xla" "application/vnd.ms-excel"
        |> Map.add "xlam" "application/vnd.ms-excel.addin.macroEnabled.12"
        |> Map.add "xlc" "application/vnd.ms-excel"
        |> Map.add "xld" "application/vnd.ms-excel"
        |> Map.add "xlk" "application/vnd.ms-excel"
        |> Map.add "xll" "application/vnd.ms-excel"
        |> Map.add "xlm" "application/vnd.ms-excel"
        |> Map.add "xls" "application/vnd.ms-excel"
        |> Map.add "xlsb" "application/vnd.ms-excel.sheet.binary.macroEnabled.12"
        |> Map.add "xlsm" "application/vnd.ms-excel.sheet.macroEnabled.12"
        |> Map.add "xlsx" "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        |> Map.add "xlt" "application/vnd.ms-excel"
        |> Map.add "xltm" "application/vnd.ms-excel.template.macroEnabled.12"
        |> Map.add "xltx" "application/vnd.openxmlformats-officedocument.spreadsheetml.template"
        |> Map.add "xlw" "application/vnd.ms-excel"
        |> Map.add "xml" "text/xml"
        |> Map.add "xmp" "application/octet-stream"
        |> Map.add "xmta" "application/xml"
        |> Map.add "xof" "x-world/x-vrml"
        |> Map.add "XOML" "text/plain"
        |> Map.add "xpm" "image/x-xpixmap"
        |> Map.add "xps" "application/vnd.ms-xpsdocument"
        |> Map.add "xrm-s" "text/xml"
        |> Map.add "xsc" "application/xml"
        |> Map.add "xsd" "text/xml"
        |> Map.add "xsf" "text/xml"
        |> Map.add "xsl" "text/xml"
        |> Map.add "xslt" "text/xml"
        |> Map.add "xsn" "application/octet-stream"
        |> Map.add "xss" "application/xml"
        |> Map.add "xspf" "application/xspf+xml"
        |> Map.add "xtp" "application/octet-stream"
        |> Map.add "xwd" "image/x-xwindowdump"
        |> Map.add "z" "application/x-compress"
        |> Map.add "zip" "application/zip"

    let defaultMimeType =
        "application/octet-stream"

    let getMimeType = flip Map.tryFind mimeTypes

    let getFileContentType (fileName: string) =
        fileName.Split('.')
        |> Array.tryLast
        |> Option.bind getMimeType
        |> Option.defaultWith (fun _ -> defaultMimeType)
