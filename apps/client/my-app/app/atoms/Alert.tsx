import React, { ReactNode } from 'react';

interface AlertProps {
  children: ReactNode;
  variant?: 'info' | 'destructive';
}

export const Alert: React.FC<AlertProps> = ({ children, variant = 'info' }) => {
  const variantClasses = {
    info: 'bg-blue-100 text-blue-700',
    destructive: 'bg-red-100 text-red-700',
  };
  return (
    <div className={`p-4 rounded ${variantClasses[variant]}`}>
      {children}
    </div>
  );
};

interface AlertDescriptionProps {
  children: ReactNode;
}

export const AlertDescription: React.FC<AlertDescriptionProps> = ({ children }) => {
  return <p className="text-sm">{children}</p>;
};
