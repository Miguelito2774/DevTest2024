import type { Metadata } from "next";
import "./globals.css";
import { Toaster } from 'sonner';

export const metadata: Metadata = {
  title: "Polls App",
  description: "App to manage polls",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className = "flex min-h-screen flex-col">
        <Toaster />
      </body>
    </html>
  );
}
