importScripts(
  "https://storage.googleapis.com/workbox-cdn/releases/4.3.1/workbox-sw.js"
);
const version = "ns26122019v3";
const precacheCacheName = workbox.core.cacheNames.precache;
const runtimeCacheName = workbox.core.cacheNames.runtime;

workbox.skipWaiting();
workbox.clientsClaim();
