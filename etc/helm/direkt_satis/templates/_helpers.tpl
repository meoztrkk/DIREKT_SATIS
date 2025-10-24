,
{{- define "direkt_satis.hosts.webpublic" -}}
{{- print "https://" (.Values.global.hosts.webpublic | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
{{- define "direkt_satis.hosts.httpapi" -}}
{{- print "https://" (.Values.global.hosts.httpapi | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
{{- define "direkt_satis.hosts.angular" -}}
{{- print "https://" (.Values.global.hosts.angular | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
{{- define "direkt_satis.hosts.authserver" -}}
{{- print "https://" (.Values.global.hosts.authserver | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
